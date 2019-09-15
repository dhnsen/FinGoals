using Microsoft.EntityFrameworkCore.Migrations;

namespace FinGoals.Data.Migrations
{
    public partial class FixGoalName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Goals",
                table: "Goals");

            migrationBuilder.RenameTable(
                name: "Goals",
                newName: "SavingsGoals");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SavingsGoals",
                table: "SavingsGoals",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SavingsGoals",
                table: "SavingsGoals");

            migrationBuilder.RenameTable(
                name: "SavingsGoals",
                newName: "Goals");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Goals",
                table: "Goals",
                column: "Id");
        }
    }
}
