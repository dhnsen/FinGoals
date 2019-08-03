using Microsoft.EntityFrameworkCore.Migrations;

namespace FinGoals.Data.Migrations
{
    public partial class CreateSavingsAmount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SavingsAmounts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Amount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingsAmounts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SavingsAmounts");
        }
    }
}
