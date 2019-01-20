using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Migrations
{
    public partial class AddedPublicId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.RenameColumn(
            //     name: "introduction",
            //     table: "Users",
            //     newName: "Introduction");

            // migrationBuilder.RenameColumn(
            //     name: "url",
            //     table: "Photos",
            //     newName: "Url");

            // migrationBuilder.AddColumn<string>(
            //     name: "Interests",
            //     table: "Users",
            //     nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PublicID",
                table: "Photos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropColumn(
            //     name: "Interests",
            //     table: "Users");

            migrationBuilder.DropColumn(
                name: "PublicID",
                table: "Photos");

            // migrationBuilder.RenameColumn(
            //     name: "Introduction",
            //     table: "Users",
            //     newName: "introduction");

            // migrationBuilder.RenameColumn(
            //     name: "Url",
            //     table: "Photos",
            //     newName: "url");
        }
    }
}
