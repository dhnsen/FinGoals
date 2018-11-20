namespace FinGoals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedGoalClass : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Goals", name: "User_Id", newName: "ApplicationUserId");
            RenameIndex(table: "dbo.Goals", name: "IX_User_Id", newName: "IX_ApplicationUserId");
            AddColumn("dbo.Goals", "Description", c => c.String());
            AlterColumn("dbo.Goals", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Goals", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Goals", "Description");
            RenameIndex(table: "dbo.Goals", name: "IX_ApplicationUserId", newName: "IX_User_Id");
            RenameColumn(table: "dbo.Goals", name: "ApplicationUserId", newName: "User_Id");
        }
    }
}
