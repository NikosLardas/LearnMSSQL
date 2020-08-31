namespace LearnMSSQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAgeToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Age");
        }
    }
}
