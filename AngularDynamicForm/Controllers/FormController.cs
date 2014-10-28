using AngularDynamicForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularDynamicForm.Controllers
{
    public class FormController : ApiController
    {
        Form Form = new Form
        {
            Questions = new List<Question> { 
                new Question{
                    Name = "Question1",
                    Label = "Please answer my question 1",
                    Type = QuestionType.Text.ToString(),
                    Value = ""
                },
                new Question{
                    Name = "Question2",
                    Label = "Please select for my question 2",
                    Type = QuestionType.Select.ToString(),
                    Value =  "",
                    Options = new List<Option>{
                        new Option{ Value = "Select1", Label = "This is Select 1" },
                        new Option{ Value = "Select2", Label = "This is Select 2" },
                        new Option{ Value = "Select3", Label = "This is Select 3" },
                        new Option{ Value = "Select4", Label = "This is Select 4" }
                    }
                },
                new Question{
                    Name = "Question3",
                    Label = "Please check my question 3",
                    Type = QuestionType.Radio.ToString(),
                    Value = "",
                    Options = new List<Option>{
                        new Option{ Value = "Radio1", Label = "This is Radio 1" },
                        new Option{ Value = "Radio2", Label = "This is Radio 2" },
                        new Option{ Value = "Radio3", Label = "This is Radio 3" },
                        new Option{ Value = "Radio4", Label = "This is Radio 4" }
                    }
                }
            }
        };

        public Form Get() {
            return Form;
        }
    }
}
