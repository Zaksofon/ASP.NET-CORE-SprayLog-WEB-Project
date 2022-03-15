using Microsoft.EntityFrameworkCore.Migrations;

namespace SprayLog.Data.Migrations
{
    public partial class SolutionTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PesticideSolutionTypeId",
                table: "Crops",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PesticideSolutionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PesticideType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PesticideSolutionTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Crops_PesticideSolutionTypeId",
                table: "Crops",
                column: "PesticideSolutionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Crops_PesticideSolutionTypes_PesticideSolutionTypeId",
                table: "Crops",
                column: "PesticideSolutionTypeId",
                principalTable: "PesticideSolutionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crops_PesticideSolutionTypes_PesticideSolutionTypeId",
                table: "Crops");

            migrationBuilder.DropTable(
                name: "PesticideSolutionTypes");

            migrationBuilder.DropIndex(
                name: "IX_Crops_PesticideSolutionTypeId",
                table: "Crops");

            migrationBuilder.DropColumn(
                name: "PesticideSolutionTypeId",
                table: "Crops");
        }
    }
}
