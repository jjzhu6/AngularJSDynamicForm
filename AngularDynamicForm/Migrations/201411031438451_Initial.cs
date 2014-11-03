namespace AngularDynamicForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Form",
                c => new
                    {
                        FormId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.FormId);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        QuestionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Label = c.String(),
                        Type = c.String(),
                        FormId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QuestionId)
                .ForeignKey("dbo.Form", t => t.FormId, cascadeDelete: true)
                .Index(t => t.FormId);
            
            CreateTable(
                "dbo.Option",
                c => new
                    {
                        OptionId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                        Label = c.String(),
                        QuestionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OptionId)
                .ForeignKey("dbo.Question", t => t.QuestionId, cascadeDelete: true)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.Respondent",
                c => new
                    {
                        RespondentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.RespondentId);
            
            CreateTable(
                "dbo.Response",
                c => new
                    {
                        ResponseId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                        QuestionId = c.Int(nullable: false),
                        RespondentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ResponseId)
                .ForeignKey("dbo.Question", t => t.QuestionId, cascadeDelete: true)
                .ForeignKey("dbo.Respondent", t => t.RespondentId, cascadeDelete: true)
                .Index(t => t.QuestionId)
                .Index(t => t.RespondentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Response", "RespondentId", "dbo.Respondent");
            DropForeignKey("dbo.Response", "QuestionId", "dbo.Question");
            DropForeignKey("dbo.Option", "QuestionId", "dbo.Question");
            DropForeignKey("dbo.Question", "FormId", "dbo.Form");
            DropIndex("dbo.Response", new[] { "RespondentId" });
            DropIndex("dbo.Response", new[] { "QuestionId" });
            DropIndex("dbo.Option", new[] { "QuestionId" });
            DropIndex("dbo.Question", new[] { "FormId" });
            DropTable("dbo.Response");
            DropTable("dbo.Respondent");
            DropTable("dbo.Option");
            DropTable("dbo.Question");
            DropTable("dbo.Form");
        }
    }
}
