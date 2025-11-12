using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoteilerProject.DataaccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "staffs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "staffs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
