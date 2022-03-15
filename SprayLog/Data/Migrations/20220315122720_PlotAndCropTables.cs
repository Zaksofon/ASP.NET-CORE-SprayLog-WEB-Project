using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SprayLog.Data.Migrations
{
    public partial class PlotAndCropTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlotName = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CropId = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Crops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CropName = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    PlantedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Batch = table.Column<int>(type: "int", nullable: false),
                    PlotId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Crops_Plots_PlotId",
                        column: x => x.PlotId,
                        principalTable: "Plots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Crops_PlotId",
                table: "Crops",
                column: "PlotId");

            migrationBuilder.CreateIndex(
                name: "IX_Plots_CropId",
                table: "Plots",
                column: "CropId");

            migrationBuilder.AddForeignKey(
                name: "FK_Plots_Crops_CropId",
                table: "Plots",
                column: "CropId",
                principalTable: "Crops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crops_Plots_PlotId",
                table: "Crops");

            migrationBuilder.DropTable(
                name: "Plots");

            migrationBuilder.DropTable(
                name: "Crops");
        }
    }
}
