namespace CodeFirstMVCAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentTables",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        City = c.String(),
                        Branch = c.String(),
                        Percentage = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentTables");
        }
    }
}
