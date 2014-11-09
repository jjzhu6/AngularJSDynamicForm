namespace AngularDynamicForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuestionOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Question", "Order", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Question", "Order");
        }
    }
}
