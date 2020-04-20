namespace Software2_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingRightAnswer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.QuestionModels", "rightAnswer", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.QuestionModels", "rightAnswer");
        }
    }
}
