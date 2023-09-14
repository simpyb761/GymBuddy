using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymBuddy.Migrations
{
    public partial class Initialization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryMuscle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondaryMuscle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntensityLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaveCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercises");
        }
    }
}
