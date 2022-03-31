using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManager.Data.Migrations
{
    public partial class UpdateAdminPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
