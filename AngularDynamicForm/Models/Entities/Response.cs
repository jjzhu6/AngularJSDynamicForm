using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDynamicForm.Models.Entities
{
    public class Response
    {
        public int ResponseId { get; set; }
        public string Value { get; set; }

        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public int RespondentId { get; set; }
        public virtual Respondent Respondent { get; set; }
    }
}