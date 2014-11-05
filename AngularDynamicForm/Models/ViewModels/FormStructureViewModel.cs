using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDynamicForm.Models.ViewModels
{
    public class FormStructureViewModel
    {
        public int FormId { get; set; }
        public string Name { get; set; }

        public IList<FormQuestion> Questions { set; get; }
    }
}