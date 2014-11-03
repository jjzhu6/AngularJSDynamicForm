using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDynamicForm.Models
{
    public class ResponseItem
    {
        public int FormId { get; set; }
        public int RespondentId { get; set; }
        public string FormName { get; set; }
        public string RespondentName { get; set; }
        public string RespondentEmail { get; set; }
    }
}