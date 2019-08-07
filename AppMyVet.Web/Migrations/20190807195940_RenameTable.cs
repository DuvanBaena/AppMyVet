using Microsoft.EntityFrameworkCore.Migrations;

namespace AppMyVet.Web.Migrations
{
    public partial class RenameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblHistory_ServiceType_ServiceTypeId",
                table: "TblHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_TblPet_PetType_PetTypeId",
                table: "TblPet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceType",
                table: "ServiceType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PetType",
                table: "PetType");

            migrationBuilder.RenameTable(
                name: "ServiceType",
                newName: "TblServiceType");

            migrationBuilder.RenameTable(
                name: "PetType",
                newName: "TblPetType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblServiceType",
                table: "TblServiceType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblPetType",
                table: "TblPetType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblHistory_TblServiceType_ServiceTypeId",
                table: "TblHistory",
                column: "ServiceTypeId",
                principalTable: "TblServiceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblPet_TblPetType_PetTypeId",
                table: "TblPet",
                column: "PetTypeId",
                principalTable: "TblPetType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblHistory_TblServiceType_ServiceTypeId",
                table: "TblHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_TblPet_TblPetType_PetTypeId",
                table: "TblPet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblServiceType",
                table: "TblServiceType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblPetType",
                table: "TblPetType");

            migrationBuilder.RenameTable(
                name: "TblServiceType",
                newName: "ServiceType");

            migrationBuilder.RenameTable(
                name: "TblPetType",
                newName: "PetType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceType",
                table: "ServiceType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetType",
                table: "PetType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblHistory_ServiceType_ServiceTypeId",
                table: "TblHistory",
                column: "ServiceTypeId",
                principalTable: "ServiceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblPet_PetType_PetTypeId",
                table: "TblPet",
                column: "PetTypeId",
                principalTable: "PetType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
