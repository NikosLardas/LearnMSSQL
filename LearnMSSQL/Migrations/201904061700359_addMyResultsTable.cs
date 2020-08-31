namespace LearnMSSQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMyResultsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyResults",
                c => new
                    {
                        UserID = c.String(nullable: false, maxLength: 128),
                        TestName = c.String(nullable: false, maxLength: 128),
                        TestSubject = c.String(),
                        Difficulty = c.String(),
                        Time = c.DateTime(nullable: false),
                        Grade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.TestName });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MyResults");
        }
    }
}

