using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManager.Data.Migrations
{
    public partial class UpdateAdminPassword2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29e3e65a-a28d-453c-8d80-a0821537224f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ab3566ce-43be-422e-a324-e01e3321b3ec", "9474bc5b-85c6-42af-b1cd-b0f36aded62d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab3566ce-43be-422e-a324-e01e3321b3ec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9474bc5b-85c6-42af-b1cd-b0f36aded62d");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "ab3566ce-43be-422e-a324-e01e3321b3ec", "04e6f3b6-9ac7-4421-9947-71b29b7f7488", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "29e3e65a-a28d-453c-8d80-a0821537224f", "1f3e6171-5f07-4c2c-826f-5649fe763b36", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContractEndDate", "DateOfIssue", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NationalId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9474bc5b-85c6-42af-b1cd-b0f36aded62d", 0, "28243d60-99da-4ffd-8ba0-781830e1e510", null, new DateTime(2022, 3, 27, 8, 37, 11, 533, DateTimeKind.Utc).AddTicks(8870), "admin@admin.bg", true, "Admin", true, "Admin", false, null, null, "1234567890", "admin@admin.bg", "ADMIN", "AQAAAAEAACcQAAAAEKH5+HOwOX/lW27NQnrZi0nIDGVLZKT7lyUWdjIsXkFQQ4x6ycDW7J8MGQbwx8vE/g==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ab3566ce-43be-422e-a324-e01e3321b3ec", "9474bc5b-85c6-42af-b1cd-b0f36aded62d" });
        }
    }
}
