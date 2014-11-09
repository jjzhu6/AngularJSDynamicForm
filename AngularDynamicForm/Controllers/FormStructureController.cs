using AngularDynamicForm.Models;
using AngularDynamicForm.Models.Entities;
using AngularDynamicForm.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularDynamicForm.Controllers
{
    public class FormStructureController : ApiController
    {
        public int save(FormViewModel form)
        {
            var formEntity = new Form { Name = form.Name, FormId = form.FormId };

            using (var db = new FormContext())
            {
                db.Entry(formEntity).State = formEntity.FormId == 0 ?
                                   EntityState.Added :
                                   EntityState.Modified; 
                db.SaveChanges();
            }
            var questions = form.Questions != null ? form.Questions.Select(q => new Question
            {
                FormId = formEntity.FormId,
                QuestionId = q.QuestionId,
                Order = q.Order,
                Type = q.Type,
                Name = q.Name,
                Label = q.Label,
                Options = q.Options != null ? q.Options.Select(o => new Option { 
                    QuestionId = q.QuestionId,
                    OptionId = o.OptionId,
                    Label = o.Label,
                    Value = o.Label
                }).ToList() : new List<Option>()
            }).ToList() : new List<Question>();
            using (var db = new FormContext())
            {
                questions.ForEach(q => {
                    db.Entry(q).State = q.QuestionId == 0 ?
                                   EntityState.Added :
                                   EntityState.Modified;
                    q.Options.ToList().ForEach(o => db.Entry(o).State = o.OptionId == 0 ?
                                   EntityState.Added :
                                   EntityState.Modified);
                });
                db.SaveChanges();
            }

            return formEntity.FormId;
        }
    }
}
