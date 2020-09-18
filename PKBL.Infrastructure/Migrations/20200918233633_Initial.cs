using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PKBL.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_Companies",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_Dropdowns",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Item = table.Column<string>(maxLength: 50, nullable: true),
                    Value = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Dropdowns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_JenisKreditKemitraans",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IdJenisProgram = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_JenisKreditKemitraans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_KantorCabangs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    HeadName = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Province_Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_KantorCabangs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_KotaKabupatens",
                columns: table => new
                {
                    City_Id = table.Column<string>(maxLength: 5, nullable: false),
                    City_Id2 = table.Column<string>(nullable: true),
                    City_AppCode = table.Column<string>(nullable: true),
                    City_Name = table.Column<string>(nullable: true),
                    Province_Code = table.Column<string>(nullable: true),
                    Prefix = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_KotaKabupatens", x => x.City_Id);
                });

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
                    RequestorPhone1 = table.Column<string>(maxLength: 64, nullable: true),
                    RequestorPhone2 = table.Column<string>(maxLength: 64, nullable: true),
                    RequestorMail = table.Column<string>(maxLength: 64, nullable: true),
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

            migrationBuilder.CreateTable(
                name: "M_Provinces",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CapitalName = table.Column<string>(nullable: true),
                    BranchCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_RefDataUsahaMitras",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CompSectorDetail = table.Column<string>(nullable: true),
                    CompName = table.Column<string>(nullable: false),
                    CompCEO = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CityId = table.Column<string>(maxLength: 5, nullable: true),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: true),
                    Phone1 = table.Column<string>(maxLength: 30, nullable: true),
                    Phone2 = table.Column<string>(maxLength: 30, nullable: true),
                    Fax = table.Column<string>(maxLength: 30, nullable: true),
                    Email = table.Column<string>(maxLength: 30, nullable: true),
                    OwnWorkPlace = table.Column<bool>(nullable: false),
                    WorkPlace_Enddate = table.Column<DateTime>(nullable: true),
                    ActiveSince = table.Column<DateTime>(nullable: false),
                    Workforce = table.Column<int>(nullable: false),
                    WorkingCapital = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Investment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MonthlyRevenue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompanyUnit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HasJournalAdmin = table.Column<bool>(nullable: false),
                    JournalAdministration = table.Column<string>(nullable: true),
                    HasOtherLoan = table.Column<bool>(nullable: false),
                    OtherLoanAt = table.Column<string>(nullable: true),
                    OtherLoanAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MitraId = table.Column<int>(nullable: false),
                    MGRProposalNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_RefDataUsahaMitras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_SektorKemitraans",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Sector_Name = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SektorKemitraans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_Suppliers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    SupplierName = table.Column<string>(nullable: true),
                    Alamat = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Keterangan = table.Column<string>(nullable: true),
                    Pic = table.Column<string>(nullable: true),
                    Jabatan = table.Column<string>(nullable: true),
                    BranchCode = table.Column<string>(nullable: true),
                    SupplierCode = table.Column<string>(nullable: true),
                    TglDaftar = table.Column<DateTime>(nullable: true),
                    group_penokode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "M_CabProps",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Cabang = table.Column<string>(maxLength: 30, nullable: true),
                    Propinsi = table.Column<int>(nullable: false),
                    ProvinceId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_CabProps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M_CabProps_M_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "M_Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_M_CabProps_ProvinceId",
                table: "M_CabProps",
                column: "ProvinceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "M_CabProps");

            migrationBuilder.DropTable(
                name: "M_Companies");

            migrationBuilder.DropTable(
                name: "M_Dropdowns");

            migrationBuilder.DropTable(
                name: "M_JenisKreditKemitraans");

            migrationBuilder.DropTable(
                name: "M_KantorCabangs");

            migrationBuilder.DropTable(
                name: "M_KotaKabupatens");

            migrationBuilder.DropTable(
                name: "M_Mitras");

            migrationBuilder.DropTable(
                name: "M_RefDataUsahaMitras");

            migrationBuilder.DropTable(
                name: "M_SektorKemitraans");

            migrationBuilder.DropTable(
                name: "M_Suppliers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "M_Provinces");
        }
    }
}
