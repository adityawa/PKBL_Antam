using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PKBL.Infrastructure.Migrations
{
    public partial class UpdateKotaKabupaten : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "M_KotaKabupatens",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "M_KotaKabupatens",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "M_KotaKabupatens",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "M_KotaKabupatens",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "M_KotaKabupatens",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "M_KotaKabupatens");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "M_KotaKabupatens");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "M_KotaKabupatens");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "M_KotaKabupatens");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "M_KotaKabupatens");
        }
    }
}
