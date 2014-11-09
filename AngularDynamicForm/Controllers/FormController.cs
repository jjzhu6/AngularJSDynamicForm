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
                    FormId = s.FormId,
                    Name = s.Name,
                    Questions = s.Questions.OrderBy(q => q.QuestionId).Select(q => new FormQuestion
                    {
                        QuestionId = q.QuestionId,
                        Name = q.Name,
                        Label = q.Label,
                        Type = q.Type,
                        Options = q.Options.OrderBy(o => o.OptionId).Select(o => new FormOption { OptionId = o.OptionId, Label = o.Label, Value = o.Value }).ToList()
                    }).ToList()
                }
                ).FirstOrDefault();                         
            }
            return form;
        }

        public FormViewModel GetSavedForm(int formId, int respondentId)
        {
            var form = new FormViewModel();
            using (var db = new FormContext())
            {
                var respondent = db.Respondents.AsQueryable().Where(r => r.RespondentId == respondentId).FirstOrDefault();
                form = db.Forms.AsQueryable().Where(f => f.FormId == formId).Select(s => new FormViewModel
                {
                    FormId = s.FormId,
                    Name = s.Name,
                    RespondentFirstName = respondent.FirstName,
                    RespondentLastName = respondent.LastName,
                    RespondentEmailAddress = respondent.EmailAddress,
                    Questions = s.Questions.OrderBy(q => q.QuestionId).Select(q => new FormQuestion
                    {
                        QuestionId = q.QuestionId,
                        Name = q.Name,
                        Label = q.Label,
                        Type = q.Type,
                        Value = db.Responses.Where(r => r.QuestionId == q.QuestionId && r.RespondentId == respondent.RespondentId).Select(ss => ss.Value).FirstOrDefault(),
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
            using (var db = new FormContext())
            {
                var respodent = new Respondent
                {
                    FirstName = form.RespondentFirstName,
                    LastName = form.RespondentLastName,
                    EmailAddress = form.RespondentEmailAddress
                };

                var responses = form.Questions.Select(q => new Response { Value = q.Value, QuestionId = q.QuestionId, Respondent = respodent }).ToList();

                db.Responses.AddRange(responses);
                db.SaveChanges();
            }
        }

        public IList<ResponseItem> GetResponseList(int formId)
        {
            var list = new List<ResponseItem>();
            using (var db = new FormContext())
            {
                list = db.Responses.AsQueryable().Where(r => r.Question.FormId == formId).Select(
                        s => new ResponseItem { 
                            FormId = s.Question.FormId, 
                            FormName = s.Question.Form.Name, 
                            RespondentId = s.RespondentId, 
                            RespondentName = s.Respondent.FirstName + " " + s.Respondent.LastName, 
                            RespondentEmail = s.Respondent.EmailAddress 
                        }
                    ).Distinct().ToList();
            }
            return list;
        }
    }
}
