using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManager.Data.Migrations
{
    public partial class AddModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5b94daa-009f-4df4-83c4-0780eb4d781d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "97b255f2-ec0c-449c-b0dc-d8adf36deb56", "70980ce4-efc6-4d50-bbba-d7c8d1d83a4b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97b255f2-ec0c-449c-b0dc-d8adf36deb56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70980ce4-efc6-4d50-bbba-d7c8d1d83a4b");

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StardDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasBreakfast = table.Column<bool>(type: "bit", nullable: false),
                    HasAllInclusive = table.Column<bool>(type: "bit", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    IsFree = table.Column<bool>(type: "bit", nullable: false),
                    AdultPrice = table.Column<double>(type: "float", nullable: false),
                    ChildPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAdult = table.Column<bool>(type: "bit", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "83bfb088-2b04-474e-b9e3-84cd8669a258", "a6c5791e-51ca-4c09-a351-a7e8300dcb0f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c42b035-ef49-46ea-a5e9-20f9b894fb3a", "53765fe0-d098-4d58-9eec-f1c932baf8b4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContractEndDate", "DateOfIssue", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NationalId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "476a7e82-6b1f-4b0a-b180-d186c110ce31", 0, "65bb29cc-6752-441c-965f-956dd9a0d50e", null, new DateTime(2022, 3, 27, 8, 15, 6, 9, DateTimeKind.Utc).AddTicks(5638), "admin@admin.bg", true, "Admin", true, "Admin", false, null, null, "1234567890", "admin@admin.bg", "ADMIN", "AQAAAAEAACcQAAAAECApXb4wSW7VuCoXdnGyyVKQG38BlasWB4xF0xmVuMvqsvKu1S/bqyGN4m4dkQLFjg==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "83bfb088-2b04-474e-b9e3-84cd8669a258", "476a7e82-6b1f-4b0a-b180-d186c110ce31" });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ReservationId",
                table: "Clients",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c42b035-ef49-46ea-a5e9-20f9b894fb3a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "83bfb088-2b04-474e-b9e3-84cd8669a258", "476a7e82-6b1f-4b0a-b180-d186c110ce31" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83bfb088-2b04-474e-b9e3-84cd8669a258");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "476a7e82-6b1f-4b0a-b180-d186c110ce31");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "97b255f2-ec0c-449c-b0dc-d8adf36deb56", "c2c52708-0e46-41d9-8464-a633ef78a727", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5b94daa-009f-4df4-83c4-0780eb4d781d", "83fae8fe-c201-476d-9f38-26f924cf8189", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContractEndDate", "DateOfIssue", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NationalId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "70980ce4-efc6-4d50-bbba-d7c8d1d83a4b", 0, "265f470a-4c37-4b81-8feb-83ebfe1300d9", null, new DateTime(2022, 3, 26, 11, 24, 37, 431, DateTimeKind.Utc).AddTicks(9691), "admin@admin.bg", true, "Admin", true, "Admin", false, null, null, "1234567890", "admin@admin.bg", "ADMIN", "AQAAAAEAACcQAAAAEBAIaFBVEOWtWSVeUZoV4Dbh+QcNLMlEtQ86xwjtpYtxMpP1J8ZO8/oyptFyJUTB6w==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "97b255f2-ec0c-449c-b0dc-d8adf36deb56", "70980ce4-efc6-4d50-bbba-d7c8d1d83a4b" });
        }
    }
}
