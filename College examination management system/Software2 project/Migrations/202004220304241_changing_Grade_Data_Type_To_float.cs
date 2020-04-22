namespace Software2_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changing_Grade_Data_Type_To_float : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ExamModels", "grade", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ExamModels", "grade", c => c.Short(nullable: false));
        }
    }
}
