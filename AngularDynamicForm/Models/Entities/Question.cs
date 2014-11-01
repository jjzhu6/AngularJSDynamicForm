using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AngularDynamicForm.Models.Entities
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public QuestionType Type { get; set; }
        public virtual IList<Option> Options { get; set; }
        public virtual IList<Response> Responses { get; set; }

        public int FormId { get; set; }
        public virtual Form Form { get; set; }
    }
}
