using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolokwium2.Migrations
{
    public partial class AddedFireTruckActionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FireTruckActions",
                columns: table => new
                {
                    IdFireTruckAction = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFireTruck = table.Column<int>(nullable: false),
                    IdAction = table.Column<int>(nullable: false),
                    AssignmentDate = table.Column<DateTime>(nullable: false),
                    IdFireTruck0 = table.Column<int>(name: "{IdFireTruck}", nullable: true),
                    IdAction0 = table.Column<int>(name: "{IdAction}", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireTruckActions", x => x.IdFireTruckAction);
                    table.ForeignKey(
                        name: "FK_FireTruckActions_Actions_{IdAction}",
                        column: x => x.IdAction0,
                        principalTable: "Actions",
                        principalColumn: "IdAction",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FireTruckActions_FireTrucks_{IdFireTruck}",
                        column: x => x.IdFireTruck0,
                        principalTable: "FireTrucks",
                        principalColumn: "IdFireTruck",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FireTruckActions_{IdAction}",
                table: "FireTruckActions",
                column: "{IdAction}");

            migrationBuilder.CreateIndex(
                name: "IX_FireTruckActions_{IdFireTruck}",
                table: "FireTruckActions",
                column: "{IdFireTruck}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FireTruckActions");
        }
    }
}
