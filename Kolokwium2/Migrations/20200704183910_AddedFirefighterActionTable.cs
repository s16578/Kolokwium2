using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolokwium2.Migrations
{
    public partial class AddedFirefighterActionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FireTruckActions_Actions_{IdAction}",
                table: "FireTruckActions");

            migrationBuilder.DropForeignKey(
                name: "FK_FireTruckActions_FireTrucks_{IdFireTruck}",
                table: "FireTruckActions");

            migrationBuilder.DropIndex(
                name: "IX_FireTruckActions_{IdAction}",
                table: "FireTruckActions");

            migrationBuilder.DropIndex(
                name: "IX_FireTruckActions_{IdFireTruck}",
                table: "FireTruckActions");

            migrationBuilder.DropColumn(
                name: "{IdAction}",
                table: "FireTruckActions");

            migrationBuilder.DropColumn(
                name: "{IdFireTruck}",
                table: "FireTruckActions");

            migrationBuilder.CreateTable(
                name: "FirefighterActions",
                columns: table => new
                {
                    IdFirefighter = table.Column<int>(nullable: false),
                    IdAction = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirefighterActions", x => new { x.IdAction, x.IdFirefighter });
                    table.ForeignKey(
                        name: "FK_FirefighterActions_Actions_IdAction",
                        column: x => x.IdAction,
                        principalTable: "Actions",
                        principalColumn: "IdAction",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FirefighterActions_Firefighters_IdFirefighter",
                        column: x => x.IdFirefighter,
                        principalTable: "Firefighters",
                        principalColumn: "IdFirefighter",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FireTruckActions_IdAction",
                table: "FireTruckActions",
                column: "IdAction");

            migrationBuilder.CreateIndex(
                name: "IX_FireTruckActions_IdFireTruck",
                table: "FireTruckActions",
                column: "IdFireTruck");

            migrationBuilder.CreateIndex(
                name: "IX_FirefighterActions_IdFirefighter",
                table: "FirefighterActions",
                column: "IdFirefighter");

            migrationBuilder.AddForeignKey(
                name: "FK_FireTruckActions_Actions_IdAction",
                table: "FireTruckActions",
                column: "IdAction",
                principalTable: "Actions",
                principalColumn: "IdAction",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FireTruckActions_FireTrucks_IdFireTruck",
                table: "FireTruckActions",
                column: "IdFireTruck",
                principalTable: "FireTrucks",
                principalColumn: "IdFireTruck",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FireTruckActions_Actions_IdAction",
                table: "FireTruckActions");

            migrationBuilder.DropForeignKey(
                name: "FK_FireTruckActions_FireTrucks_IdFireTruck",
                table: "FireTruckActions");

            migrationBuilder.DropTable(
                name: "FirefighterActions");

            migrationBuilder.DropIndex(
                name: "IX_FireTruckActions_IdAction",
                table: "FireTruckActions");

            migrationBuilder.DropIndex(
                name: "IX_FireTruckActions_IdFireTruck",
                table: "FireTruckActions");

            migrationBuilder.AddColumn<int>(
                name: "{IdAction}",
                table: "FireTruckActions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "{IdFireTruck}",
                table: "FireTruckActions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FireTruckActions_{IdAction}",
                table: "FireTruckActions",
                column: "{IdAction}");

            migrationBuilder.CreateIndex(
                name: "IX_FireTruckActions_{IdFireTruck}",
                table: "FireTruckActions",
                column: "{IdFireTruck}");

            migrationBuilder.AddForeignKey(
                name: "FK_FireTruckActions_Actions_{IdAction}",
                table: "FireTruckActions",
                column: "{IdAction}",
                principalTable: "Actions",
                principalColumn: "IdAction",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FireTruckActions_FireTrucks_{IdFireTruck}",
                table: "FireTruckActions",
                column: "{IdFireTruck}",
                principalTable: "FireTrucks",
                principalColumn: "IdFireTruck",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
