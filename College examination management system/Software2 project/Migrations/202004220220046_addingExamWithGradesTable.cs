namespace Software2_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingExamWithGradesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExamModels",
                c => new
                    {
                        id = c.Short(nullable: false, identity: true),
                        student_id = c.Short(nullable: false),
                        course_id = c.Short(nullable: false),
                        grade = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ExamModels");
        }
    }
}
