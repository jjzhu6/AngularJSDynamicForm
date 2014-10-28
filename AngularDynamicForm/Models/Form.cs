using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDynamicForm.Models
{
    public class Form
    {
        public IEnumerable<Question> Questions { set; get; }
    }
}