using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P02SoftUniConsole.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    StartDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectID);
                });

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    TownID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.TownID);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressText = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    TownID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_Addresses_Towns",
                        column: x => x.TownID,
                        principalTable: "Towns",
                        principalColumn: "TownID");
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ManagerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    JobTitle = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    ManagerID = table.Column<int>(type: "int", nullable: true),
                    HireDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Salary = table.Column<decimal>(type: "money", nullable: false),
                    AddressID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employees_Addresses",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID");
                    table.ForeignKey(
                        name: "FK_Employees_Departments",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID");
                    table.ForeignKey(
                        name: "FK_Employees_Employees",
                        column: x => x.ManagerID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID");
                });

            migrationBuilder.CreateTable(
                name: "EmployeesProjects",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesProject", x => new { x.EmployeeId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_EmployeesProjects_Employees",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID");
                    table.ForeignKey(
                        name: "FK_EmployeesProjects_Projects",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_TownID",
                table: "Addresses",
                column: "TownID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerID",
                table: "Departments",
                column: "ManagerID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AddressID",
                table: "Employees",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentID",
                table: "Employees",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ManagerID",
                table: "Employees",
                column: "ManagerID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesProject_ProjectId",
                table: "EmployeesProject",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees",
                table: "Departments",
                column: "ManagerID",
                principalTable: "Employees",
                principalColumn: "EmployeeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Towns",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees",
                table: "Departments");

            migrationBuilder.DropTable(
                name: "EmployeesProject");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Towns");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
