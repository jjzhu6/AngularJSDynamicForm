using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AngularDynamicForm.Models
{
    public class Question
    {
        public string Name { get; set; }
        public string Label { get; set; }
        public QuestionType Type { get; set; }
        public string Value { get; set; }
        public IEnumerable<Option> Options { get; set; }
    }
}
