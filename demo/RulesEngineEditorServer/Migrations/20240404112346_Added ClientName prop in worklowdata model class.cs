using Microsoft.EntityFrameworkCore.Migrations;

namespace RulesEngineEditorServer.Migrations
{
    public partial class AddedClientNamepropinworklowdatamodelclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientName",
                table: "Workflow",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "Workflow");
        }
    }
}
