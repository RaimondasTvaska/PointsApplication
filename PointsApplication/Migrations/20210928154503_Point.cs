using Microsoft.EntityFrameworkCore.Migrations;

namespace PointsApplication.Migrations
{
    public partial class Point : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PointListId",
                table: "Points",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PointLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointLists", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Points_PointListId",
                table: "Points",
                column: "PointListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Points_PointLists_PointListId",
                table: "Points",
                column: "PointListId",
                principalTable: "PointLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Points_PointLists_PointListId",
                table: "Points");

            migrationBuilder.DropTable(
                name: "PointLists");

            migrationBuilder.DropIndex(
                name: "IX_Points_PointListId",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "PointListId",
                table: "Points");
        }
    }
}
