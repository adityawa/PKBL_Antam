using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PKBL.Infrastructure.Migrations
{
    public partial class updateDB_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_Mitras",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    RequestorAddress = table.Column<string>(nullable: true),
                    AddressDistrict = table.Column<string>(nullable: true),
                    HomeOwnershipId = table.Column<int>(nullable: false),
                    RequestorPhone1 = table.Column<string>(nullable: true),
                    RequestorPhone2 = table.Column<string>(nullable: true),
                    RequestorMail = table.Column<string>(nullable: true),
                    MaritalStatusId = table.Column<int>(nullable: false),
                    EducationLevelId = table.Column<int>(nullable: false),
                    CompanyDataId = table.Column<int>(nullable: false),
                    Family_Relative_ID = table.Column<int>(nullable: false),
                    Other_Relative_ID = table.Column<int>(nullable: false),
                    Car_Mortage_ID = table.Column<int>(nullable: false),
                    Motorcycle_Mortage_ID = table.Column<int>(nullable: false),
                    Other_Mortage_ID = table.Column<int>(nullable: false),
                    MortageRemarks = table.Column<string>(nullable: true),
                    Administrative_Id = table.Column<int>(nullable: false),
                    Production_Activity_Id1 = table.Column<int>(nullable: false),
                    Production_Activity_Id2 = table.Column<int>(nullable: false),
                    Production_Activity_Id3 = table.Column<int>(nullable: false),
                    Production_Activity_Id4 = table.Column<int>(nullable: false),
                    IsProductHandMade = table.Column<bool>(nullable: false),
                    IsMachineMade = table.Column<bool>(nullable: false),
                    Owned_Tool1 = table.Column<string>(nullable: true),
                    Owned_Tool1_count = table.Column<int>(nullable: false),
                    Owned_Tool2 = table.Column<string>(nullable: true),
                    Owned_Tool2_count = table.Column<int>(nullable: false),
                    Owned_Tool3 = table.Column<string>(nullable: true),
                    Owned_Tool3_count = table.Column<int>(nullable: false),
                    Owned_Tool4 = table.Column<string>(nullable: true),
                    Owned_Tool4_count = table.Column<int>(nullable: false),
                    Service_Provided = table.Column<string>(nullable: true),
                    Marketing = table.Column<string>(nullable: true),
                    IsLocalMarket = table.Column<bool>(nullable: false),
                    IsExport = table.Column<bool>(nullable: false),
                    Checklist_Id = table.Column<int>(nullable: false),
                    UploadedFile = table.Column<string>(nullable: true),
                    InventoryUpdateId = table.Column<int>(nullable: false),
                    MGRNoProposal = table.Column<string>(nullable: true),
                    TglBermasalah = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Mitras", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_Mitras");
        }
    }
}
