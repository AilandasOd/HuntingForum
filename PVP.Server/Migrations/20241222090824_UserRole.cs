using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PVP.Server.Migrations
{
    /// <inheritdoc />
    public partial class UserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Reaction",
                table: "Likes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Frequency",
                table: "HabitUser",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Goal",
                table: "HabitUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "HabitUser",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "FirstChallengerStreak",
                table: "Challenges",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecondChallengerStreak",
                table: "Challenges",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Reaction",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "Frequency",
                table: "HabitUser");

            migrationBuilder.DropColumn(
                name: "Goal",
                table: "HabitUser");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "HabitUser");

            migrationBuilder.DropColumn(
                name: "FirstChallengerStreak",
                table: "Challenges");

            migrationBuilder.DropColumn(
                name: "SecondChallengerStreak",
                table: "Challenges");
        }
    }
}
