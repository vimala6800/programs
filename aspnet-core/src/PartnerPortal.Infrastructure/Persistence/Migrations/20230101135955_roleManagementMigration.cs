using System;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PartnerPortal.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class roleManagementMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "RolePermission",
                columns: table => new
                {
                    PId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "nvarchar(max)", nullable: false),
                    FId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    View = table.Column<bool>(type: "bit", nullable: false),
                    Add = table.Column<bool>(type: "bit", nullable: false),
                    Edit = table.Column<bool>(type: "bit", nullable: false),
                    Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermission", x => x.PId);
                });

            migrationBuilder.CreateTable(
                name: "Functionalities",
                columns: table => new
                {
                    FId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Functionalities", x => x.FId);
                });

            migrationBuilder.CreateTable(
                name: "OtherRoles",
                columns: table => new
                {
                    ORId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherRoles", x => x.ORId);
                });

            migrationBuilder.CreateTable(
               name: "BenchResources",
               columns: table => new
               {
                   BenchID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                   PartnerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                   NoOfResource = table.Column<int>(type: "int", nullable: false),
                   yearsOfExperience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   SkillSet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   RatePerHrUSD = table.Column<double>(type: "float", nullable: false),
                   Id = table.Column<int>(type: "int", nullable: false),
                   Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                   CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                   LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                   LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_BenchResources", x => x.BenchID);
               });


            migrationBuilder.CreateTable(
                name: "RoleDescriptions",
                columns: table => new
                {
                    RDId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RolesDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleDescriptions", x => x.RDId);
                });
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "209b42b4-7d12-4680-a874-2bb5cd266dcf", "2", "ProjectManager", "PROJECTMANAGER" },
                    { "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", "3", "Partner", "PARTNER" },
                    { "93849f0a-2082-466c-a2bd-e23f80e2b093", "4", "Sales", "SALES" },
                    { "e64a6efa-5bc1-4016-bbd8-be038cd6118c", "1", "Administrator", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Functionalities",
                columns: new[] { "FId", "description" },
                values: new object[,]
                {
                    { new Guid("6ffa6bb5-06fd-4597-b39e-e465a4fc30e0"), "Role Administration" },
                    { new Guid("6ffa6bb5-06fd-4597-b39e-e465a4fc30e1"), "User Administration" },
                    { new Guid("6ffa6bb5-06fd-4597-b39e-e465a4fc30e2"), "Skills/Profile" },
                    { new Guid("6ffa6bb5-06fd-4597-b39e-e465a4fc30e3"), "Bench" },
                    { new Guid("6ffa6bb5-06fd-4597-b39e-e465a4fc30e4"), "Reports" },
                    { new Guid("6ffa6bb5-06fd-4597-b39e-e465a4fc30e5"), "Project Managers" },
                    { new Guid("6ffa6bb5-06fd-4597-b39e-e465a4fc30e6"), "Partners" },
                    { new Guid("6ffa6bb5-06fd-4597-b39e-e465a4fc30e7"), "Interview" },
                    { new Guid("6ffa6bb5-06fd-4597-b39e-e465a4fc30e8"), "Resource" },
                    { new Guid("6ffa6bb5-06fd-4597-b39e-e465a4fc30e9"), "Requisition" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "04cf63f8-928b-4df2-a9fc-01e96f39cd80", 0, "1", "admin@fws", false, false, null, "ADMIN@FWS", "ADMINISTRATOR@LOCALHOST", "admin", "789788789", false, "8a2b4e9d-c3ad-47be-a09e-7083e44636b2", false, "administrator@localhost" },
                    { "4064537c-57d0-45e0-963c-d91b07ee32b2", 0, "1", "sales@fws", false, false, null, "SALES@FWS", "SALES@LOCALHOST", "sales", "965718700", false, "9d08feb6-1102-4e3b-9bc2-ce5a9b8b27ed", false, "sales@localhost" }
                });

            migrationBuilder.InsertData(
                table: "OtherRoles",
                columns: new[] { "ORId", "Address", "Company", "Photo", "UserId" },
                values: new object[,]
                {
                    { new Guid("b8026d97-49ad-49f9-8f16-010ee0347dae"), "BTM Layout", "FWS", "empty", new Guid("04cf63f8-928b-4df2-a9fc-01e96f39cd80") },
                    { new Guid("b8026d97-49ad-49f9-8f16-010ea0348dae"), "Jayanagar", "FWS", "empty", new Guid("4064537c-57d0-45e0-963c-d91b07ee32b2") }
                });

            migrationBuilder.InsertData(
                table: "RoleDescriptions",
                columns: new[] { "RDId", "RoleId", "RolesDescription" },
                values: new object[,]
                {
                    { new Guid("17c1b2f8-df20-49cf-1c65-08dae7efe031"), "93849f0a-2082-466c-a2bd-e23f80e2b093", "Sales brings project to us." },
                    { new Guid("421777ea-0c7e-4c35-1c64-08dae7efe031"), "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", "Partners provide resources." },
                    { new Guid("6eb478ef-fcd6-4ba9-1c66-08dae7efe031"), "e64a6efa-5bc1-4016-bbd8-be038cd6118c", "Administrator has all the authority." },
                    { new Guid("e12b06b4-881d-4e22-1c63-08dae7efe031"), "209b42b4-7d12-4680-a874-2bb5cd266dcf", "PM manages projects." }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e64a6efa-5bc1-4016-bbd8-be038cd6118c", "04cf63f8-928b-4df2-a9fc-01e96f39cd80" },
                    { "93849f0a-2082-466c-a2bd-e23f80e2b093", "4064537c-57d0-45e0-963c-d91b07ee32b2" }
                });

            migrationBuilder.InsertData(
             table: "RolePermission",
             columns: new[] { "PId", "Id","FId", "View", "Add","Edit","Delete"},
             values: new object[,]
             {
               {  new Guid("4064537c-57d0-45e0-963c-d91b07ee32b1"), "e64a6efa-5bc1-4016-bbd8-be038cd6118c", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E0"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d91b07ea32b2"), "e64a6efa-5bc1-4016-bbd8-be038cd6118c", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E1") ,false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d91b07ee32b3"), "e64a6efa-5bc1-4016-bbd8-be038cd6118c", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E2"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d91b07ee32b4"), "e64a6efa-5bc1-4016-bbd8-be038cd6118c", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E3"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d91b07ee32b5"), "e64a6efa-5bc1-4016-bbd8-be038cd6118c", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E4"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d91b07ee32b6"), "e64a6efa-5bc1-4016-bbd8-be038cd6118c", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E5"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d91b07ee32b7"), "e64a6efa-5bc1-4016-bbd8-be038cd6118c", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E6"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d91b07ee32b8"), "e64a6efa-5bc1-4016-bbd8-be038cd6118c", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E7") ,false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d91b07ee32b9"), "e64a6efa-5bc1-4016-bbd8-be038cd6118c", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E8"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d91b07ee32b0"), "e64a6efa-5bc1-4016-bbd8-be038cd6118c", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E9"), false,false,false,false},

               {  new Guid("4064537c-57d0-45e0-963c-d91b07ee32b2"), "93849f0a-2082-466c-a2bd-e23f80e2b093", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E0"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d81b07ee32b2"), "93849f0a-2082-466c-a2bd-e23f80e2b093", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E1"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d71b07ee32b3"), "93849f0a-2082-466c-a2bd-e23f80e2b093", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E2") ,false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d61b07ee32b4"), "93849f0a-2082-466c-a2bd-e23f80e2b093", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E3"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d51b07ee32b5"), "93849f0a-2082-466c-a2bd-e23f80e2b093", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E4"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d41b07ee32b6"), "93849f0a-2082-466c-a2bd-e23f80e2b093", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E5"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d31b07ee32b7"), "93849f0a-2082-466c-a2bd-e23f80e2b093", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E6"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d21b07ee32b8"), "93849f0a-2082-466c-a2bd-e23f80e2b093", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E7"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d11b07ee32b9"), "93849f0a-2082-466c-a2bd-e23f80e2b093", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E8"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d01b07ee32b0"), "93849f0a-2082-466c-a2bd-e23f80e2b093", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E9") ,false,false,false,false},

               {  new Guid("4064537c-57d0-45e0-963c-d90b07ee32b1"), "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E0"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d91b07ee32c2"), "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E1"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d92b07ee32b3"), "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E2"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d93b07ee32b4"), "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E3"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d94b07ee32b5"), "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E4"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d95b07ee32b6"), "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E5"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d96b07ee32b7"), "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E6"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d97b07ee32b8"), "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E7"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d98b07ee32b9"), "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E8"), false,false,false,false},
               {  new Guid("4064537c-57d0-45e0-963c-d99b07ee32b0"), "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E9") ,false,false,false,false},

               {  new Guid("4004537c-57d0-45e0-963c-d91b07ee32b1"), "209b42b4-7d12-4680-a874-2bb5cd266dcf", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E0"), false,false,false,false},
               {  new Guid("4014537c-57d0-45e0-963c-d91b07ee32b2"), "209b42b4-7d12-4680-a874-2bb5cd266dcf", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E1"), false,false,false,false},
               {  new Guid("4024537c-57d0-45e0-963c-d91b07ee32b3"), "209b42b4-7d12-4680-a874-2bb5cd266dcf", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E2"), false,false,false,false},
               {  new Guid("4034537c-57d0-45e0-963c-d91b07ee32b4"), "209b42b4-7d12-4680-a874-2bb5cd266dcf", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E3"), false,false,false,false},
               {  new Guid("4044537c-57d0-45e0-963c-d91b07ee32b5"), "209b42b4-7d12-4680-a874-2bb5cd266dcf", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E4"), false,false,false,false},
               {  new Guid("4054537c-57d0-45e0-963c-d91b07ee32b6"), "209b42b4-7d12-4680-a874-2bb5cd266dcf", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E5"), false,false,false,false},
               {  new Guid("4060537c-57d0-45e0-963c-d91b07ee32b7"), "209b42b4-7d12-4680-a874-2bb5cd266dcf", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E6"), false,false,false,false},
               {  new Guid("4074537c-57d0-45e0-963c-d91b07ee32b8"), "209b42b4-7d12-4680-a874-2bb5cd266dcf", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E7"), false,false,false,false},
               {  new Guid("4084537c-57d0-45e0-963c-d91b07ee32b9"), "209b42b4-7d12-4680-a874-2bb5cd266dcf", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E8"), false,false,false,false},
               {  new Guid("4094537c-57d0-45e0-963c-d91b07ee32b0"), "209b42b4-7d12-4680-a874-2bb5cd266dcf", new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E9"), false,false,false,false},
             });



        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_requisitions_RequisitionID",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Currencies_requisitions_RequisitionID",
                table: "Currencies");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_requisitions_RequisitionID",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectManagers_requisitions_RequisitionID",
                table: "ProjectManagers");

            migrationBuilder.DropTable(
                name: "Functionalities");

            migrationBuilder.DropTable(
                name: "IdentityUser");

            migrationBuilder.DropTable(
                name: "OtherRoles");

            migrationBuilder.DropTable(
                name: "PartnerSkills");

            migrationBuilder.DropTable(
                name: "projectManagerSkills");

            migrationBuilder.DropTable(
                name: "RateCards");

            migrationBuilder.DropTable(
                name: "RequisitionFiles");

            migrationBuilder.DropTable(
                name: "RequisitionJDs");

            migrationBuilder.DropTable(
                name: "RequisitionPartners");

            migrationBuilder.DropTable(
                name: "RequisitionSkills");

            migrationBuilder.DropTable(
                name: "RoleDescriptions");

            migrationBuilder.DropTable(
                name: "RolePermission");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "requisitions");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "ProjectManagers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "209b42b4-7d12-4680-a874-2bb5cd266dcf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e64a6efa-5bc1-4016-bbd8-be038cd6118c", "04cf63f8-928b-4df2-a9fc-01e96f39cd80" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "93849f0a-2082-466c-a2bd-e23f80e2b093", "4064537c-57d0-45e0-963c-d91b07ee32b2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93849f0a-2082-466c-a2bd-e23f80e2b093");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e64a6efa-5bc1-4016-bbd8-be038cd6118c");

           
        }
    }
}
