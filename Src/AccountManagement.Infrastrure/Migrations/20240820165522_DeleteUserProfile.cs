using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Infrastrure.Migrations
{
    public partial class DeleteUserProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserProfile",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserProfile",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
