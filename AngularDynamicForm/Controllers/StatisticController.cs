using AngularDynamicForm.Models;
using AngularDynamicForm.Models.Entities;
using AngularDynamicForm.Models.Enums;
using AngularDynamicForm.Models.ViewModels;
using AngularDynamicForm.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularDynamicForm.Controllers
{
    public class StatisticController : ApiController
    {
        public IList<string> GetQuestionTypes()
        {
            return EnumHelper.GetEnumList<QuestionType>().Select(e => e.ToString()).ToList();
        }
    }
}
