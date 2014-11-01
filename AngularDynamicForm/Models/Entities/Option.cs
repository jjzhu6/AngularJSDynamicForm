using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AngularDynamicForm.Models.Entities
{
    public class Option
    {
        public int OptionId { get; set; }
        public string Value { get; set; }
        public string Label { get; set; }

        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}
