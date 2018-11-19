namespace FinGoals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class overrideConventionsForGoals : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Goals", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Goals", new[] { "User_Id" });
            AlterColumn("dbo.Goals", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Goals", "User_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Goals", "User_Id");
            AddForeignKey("dbo.Goals", "User_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Goals", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Goals", new[] { "User_Id" });
            AlterColumn("dbo.Goals", "User_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Goals", "Name", c => c.String());
            CreateIndex("dbo.Goals", "User_Id");
            AddForeignKey("dbo.Goals", "User_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
