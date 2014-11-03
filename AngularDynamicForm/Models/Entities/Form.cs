using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDynamicForm.Models.Entities
{
    public class Form
    {
        public int FormId { get; set; }
        public string Name { get; set; }
        public virtual IList<Question> Questions { set; get; }
        //public virtual IList<Respondent> Respondents { set; get; }
    }
}