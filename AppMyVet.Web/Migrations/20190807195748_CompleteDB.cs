using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppMyVet.Web.Migrations
{
    public partial class CompleteDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Owners",
                table: "Owners");

            migrationBuilder.RenameTable(
                name: "Owners",
                newName: "TblOwner");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblOwner",
                table: "TblOwner",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "PetType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblPet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Race = table.Column<string>(maxLength: 50, nullable: true),
                    Born = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    PetTypeId = table.Column<int>(nullable: true),
                    OwnerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblPet_TblOwner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "TblOwner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblPet_PetType_PetTypeId",
                        column: x => x.PetTypeId,
                        principalTable: "PetType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblAgenda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    IsAvailable = table.Column<bool>(nullable: false),
                    OwnerId = table.Column<int>(nullable: true),
                    PetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAgenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblAgenda_TblOwner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "TblOwner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblAgenda_TblPet_PetId",
                        column: x => x.PetId,
                        principalTable: "TblPet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    ServiceTypeId = table.Column<int>(nullable: true),
                    PetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblHistory_TblPet_PetId",
                        column: x => x.PetId,
                        principalTable: "TblPet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblHistory_ServiceType_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblAgenda_OwnerId",
                table: "TblAgenda",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_TblAgenda_PetId",
                table: "TblAgenda",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_TblHistory_PetId",
                table: "TblHistory",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_TblHistory_ServiceTypeId",
                table: "TblHistory",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TblPet_OwnerId",
                table: "TblPet",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_TblPet_PetTypeId",
                table: "TblPet",
                column: "PetTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblAgenda");

            migrationBuilder.DropTable(
                name: "TblHistory");

            migrationBuilder.DropTable(
                name: "TblPet");

            migrationBuilder.DropTable(
                name: "ServiceType");

            migrationBuilder.DropTable(
                name: "PetType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblOwner",
                table: "TblOwner");

            migrationBuilder.RenameTable(
                name: "TblOwner",
                newName: "Owners");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Owners",
                table: "Owners",
                column: "Id");
        }
    }
}
