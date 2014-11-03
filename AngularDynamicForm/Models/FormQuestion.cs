using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDynamicForm.Models
{
    public class FormQuestion
    {
        public int QuestionId { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public virtual IList<FormOption> Options { get; set; }
    }
}