using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManager.Data.Migrations
{
    public partial class UpdateAdminPassword4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "381a0e4b-9cac-4a40-a8c1-be1fa5bf2796");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f2bbe768-08c5-43e0-9a3a-85698c08ad89", "c5f99f0c-023e-490b-bd09-9b894e642d30" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2bbe768-08c5-43e0-9a3a-85698c08ad89");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5f99f0c-023e-490b-bd09-9b894e642d30");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f857b432-7bc2-452d-b406-e33ec0508d91", "b685eaa7-072c-4126-b4dc-bf9b85377e32", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b204afcc-d36f-41eb-8806-18a842aca7da", "e6bce479-50c8-44df-8609-3b928c51dfd0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContractEndDate", "DateOfIssue", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NationalId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "48b19b3f-f34c-45e6-95e9-1140c6298d0f", 0, "49a7b394-4f6f-40d1-84d1-c5ed25e2661d", null, new DateTime(2022, 3, 27, 8, 50, 6, 762, DateTimeKind.Utc).AddTicks(2797), "admin@admin.bg", true, "Admin", true, "Admin", false, null, null, "1234567890", "ADMIN@ADMIN.BG", "ADMIN", "AQAAAAEAACcQAAAAEGzNNxqtOdhiFgTsyEXX/EeKlmXeYrAeZO6WCRHbQ7cd72lDcBvNeJMBa73PTInsoA==", null, false, "3d56c479-7a6b-4b5f-8618-74eb5ec13e24", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f857b432-7bc2-452d-b406-e33ec0508d91", "48b19b3f-f34c-45e6-95e9-1140c6298d0f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b204afcc-d36f-41eb-8806-18a842aca7da");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f857b432-7bc2-452d-b406-e33ec0508d91", "48b19b3f-f34c-45e6-95e9-1140c6298d0f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f857b432-7bc2-452d-b406-e33ec0508d91");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48b19b3f-f34c-45e6-95e9-1140c6298d0f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f2bbe768-08c5-43e0-9a3a-85698c08ad89", "c747b511-ee56-48e0-9187-13f3f7bebb88", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "381a0e4b-9cac-4a40-a8c1-be1fa5bf2796", "4fe301d2-2007-4e90-be40-c9eae39934df", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContractEndDate", "DateOfIssue", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NationalId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c5f99f0c-023e-490b-bd09-9b894e642d30", 0, "c8912db0-d068-47a6-aeda-407e52977684", null, new DateTime(2022, 3, 27, 8, 45, 18, 895, DateTimeKind.Utc).AddTicks(3708), "admin@admin.bg", true, "Admin", true, "Admin", false, null, null, "1234567890", "ADMIN@ADMIN.BG", "ADMIN", "AQAAAAEAACcQAAAAECNtRQgmExB9kd+79VSk1DcW/sDFVW/BUNtNUcGvutIBKMotHN8BbcQIV8awaiTlhQ==", null, false, "5395fef7-2c7a-42aa-bc32-12f30445db56", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f2bbe768-08c5-43e0-9a3a-85698c08ad89", "c5f99f0c-023e-490b-bd09-9b894e642d30" });
        }
    }
}
