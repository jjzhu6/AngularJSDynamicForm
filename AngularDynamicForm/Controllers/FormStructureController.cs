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
        public int save(Form form)
        {
            using (var db = new FormContext())
            {
                db.Entry(form).State = form.FormId == 0 ?
                                   EntityState.Added :
                                   EntityState.Modified; 
                db.SaveChanges();
            }
            return form.FormId;
        }
    }
}
