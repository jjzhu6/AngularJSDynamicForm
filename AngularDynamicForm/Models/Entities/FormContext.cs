using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AngularDynamicForm.Models.Entities
{
    public class FormContext: DbContext
    {
        public DbSet<Form> Forms { set; get; }
        public DbSet<Question> Questions { set; get; }
        public DbSet<Option> Options { set; get; }
        public DbSet<Respondent> Respondents { set; get; }
        public DbSet<Response> Responses { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}