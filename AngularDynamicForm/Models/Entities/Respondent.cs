using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDynamicForm.Models.Entities
{
    public class Respondent
    {
        public int RespondentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public int FormId { get; set; }
        public virtual Form Form { get; set; }
    }
}