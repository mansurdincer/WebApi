using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class DepartmentAndJobtitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Author = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Editor = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Departments_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobTitle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Editor = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitleId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    Author = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Editor = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employees_JobTitle_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Author", "CreatedDate", "Description", "Editor", "IsActive", "IsDeleted", "Name", "ParentId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5978), null, 0, false, false, "IT", null, null },
                    { 2, 0, new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5979), null, 0, false, false, "QA", null, null },
                    { 3, 0, new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5980), null, 0, false, false, "Sales", null, null },
                    { 4, 0, new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5981), null, 0, false, false, "Marketing", null, null },
                    { 5, 0, new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5982), null, 0, false, false, "Accounting", null, null },
                    { 6, 0, new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5982), null, 0, false, false, "Finance", null, null },
                    { 7, 0, new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5983), null, 0, false, false, "HR", null, null }
                });

            migrationBuilder.InsertData(
                table: "JobTitle",
                columns: new[] { "Id", "Author", "CreatedDate", "Description", "Editor", "IsActive", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5957), null, 0, false, false, "CEO", null },
                    { 2, 0, new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5959), null, 0, false, false, "Manager", null },
                    { 3, 0, new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5960), null, 0, false, false, "Employee", null },
                    { 4, 0, new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5960), null, 0, false, false, "Intern", null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Author", "CreatedDate", "DepartmentId", "Editor", "Email", "IsActive", "IsDeleted", "JobTitleId", "Name", "Surname", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5998), 1, 0, "mansur.dincer@filidea.com.tr", false, false, 3, "Mansur", "Dinçer", null },
                    { 2, 0, new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(6000), 2, 0, "dondu.yilmaz@filidea.com.tr", false, false, 2, "Döndü", "Yılmaz", null },
                    { 3, 0, new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(6002), 1, 0, "muhammer.sayin@filidea.com.tr", false, false, 3, "Muhammer", "Sayın", null },
                    { 4, 0, new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(6003), 1, 0, "abdullah.kasim@filidea.com.tr", false, false, 2, "Abdullah", "Kasım", null },
                    { 5, 0, new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(6004), 6, 0, "fahri.yilmaz@filidea.com.tr", false, false, 3, "Fahri", "Yılmaz", null },
                    { 6, 0, new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(6005), 4, 0, "mustafa.kalaycioglu@filidea.com.tr", false, false, 2, "Mustafa", "Kalaycıoğlu", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ParentId",
                table: "Departments",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobTitleId",
                table: "Employees",
                column: "JobTitleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "JobTitle");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1427));
        }
    }
}
