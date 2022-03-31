using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManager.Data.Migrations
{
    public partial class UpdateAdminPassword3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30bc09d0-076d-4767-b302-c1aa0ef6c5aa");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "77cdde97-39e1-4b76-932d-bb443825094a", "505894b3-13ff-4289-a18d-22d6b24021e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77cdde97-39e1-4b76-932d-bb443825094a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "505894b3-13ff-4289-a18d-22d6b24021e4");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "77cdde97-39e1-4b76-932d-bb443825094a", "6a90c233-6153-4f6d-9321-026baa21edca", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "30bc09d0-076d-4767-b302-c1aa0ef6c5aa", "ea064a3c-b445-4727-8120-fb5d695869ab", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContractEndDate", "DateOfIssue", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NationalId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "505894b3-13ff-4289-a18d-22d6b24021e4", 0, "8ef0081b-f12a-4909-92ad-6e011ebe4ed1", null, new DateTime(2022, 3, 27, 8, 43, 10, 263, DateTimeKind.Utc).AddTicks(6852), "admin@admin.bg", true, "Admin", true, "Admin", false, null, null, "1234567890", "admin@admin.bg", "ADMIN", "AQAAAAEAACcQAAAAEFtMWRNnGwi5ZgrzIZP9zRK6/shl0xnuMvyXYAWiZyemNilAbNp7sP+E2Bzk9H1cmQ==", null, false, "0fc3f48f-8f66-4049-abf9-e9cc29075138", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "77cdde97-39e1-4b76-932d-bb443825094a", "505894b3-13ff-4289-a18d-22d6b24021e4" });
        }
    }
}
