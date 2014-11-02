using AngularDynamicForm.Models;
using AngularDynamicForm.Models.Entities;
using AngularDynamicForm.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularDynamicForm.Controllers
{
    public class FormController : ApiController
    {
        public FormViewModel Get(int id)
        {
            var form = new FormViewModel();
            using (var db = new FormContext())
            {
                form = db.Forms.AsQueryable().Where(f => f.FormId == id).Select(s => new FormViewModel
                {
                    Name = s.Name,
                    Questions = s.Questions.OrderBy(q => q.QuestionId).Select(q => new FormQuestion
                    {
                        Name = q.Name,
                        Label = q.Label,
                        Type = q.Type,
                        Options = q.Options.OrderBy(o => o.OptionId).Select(o => new FormOption { Label = o.Label, Value = o.Value }).ToList()
                    }).ToList()
                }
                ).FirstOrDefault();                         
            }
            return form;
        }

        public IList<FormItem> GetList()
        {
            var forms = new List<FormItem>();

            using (var db = new FormContext())
            {
                forms = db.Forms.AsQueryable().Select(f => new FormItem { FormId = f.FormId, Name = f.Name }).ToList();
            }

            return forms;
        }

        public void save(FormViewModel form)
        {
            
        }
    }
}
