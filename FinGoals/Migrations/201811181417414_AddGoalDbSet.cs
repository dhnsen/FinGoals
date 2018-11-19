namespace FinGoals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGoalDbSet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Goals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DueDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Goals", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Goals", new[] { "User_Id" });
            DropTable("dbo.Goals");
        }
    }
}
