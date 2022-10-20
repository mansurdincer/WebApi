using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class Absenteeism : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfDismissal",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "RankId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNo",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SeniorityId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AbsenteeismType",
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
                    table.PrimaryKey("PK_AbsenteeismType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Multiplier = table.Column<float>(type: "real", nullable: false),
                    Author = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Editor = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seniorities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Multiplier = table.Column<float>(type: "real", nullable: false),
                    Author = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Editor = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seniorities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Absenteeism",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AbsenteeismTypeId = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Editor = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Absenteeism", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Absenteeism_AbsenteeismType_AbsenteeismTypeId",
                        column: x => x.AbsenteeismTypeId,
                        principalTable: "AbsenteeismType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Absenteeism_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AbsenteeismType",
                columns: new[] { "Id", "Author", "CreatedDate", "Description", "Editor", "IsActive", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1171), null, 0, false, false, "Ameliyat", null },
                    { 2, 0, new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1180), null, 0, false, false, "Covid", null },
                    { 3, 0, new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1181), null, 0, false, false, "Doğum", null },
                    { 4, 0, new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1181), null, 0, false, false, "Mazeretsiz", null },
                    { 5, 0, new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1233), null, 0, false, false, "Hastalık", null },
                    { 6, 0, new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1235), null, 0, false, false, "İş Kazası", null },
                    { 7, 0, new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1236), null, 0, false, false, "Ücretsiz İzin", null }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.InsertData(
                table: "Rank",
                columns: new[] { "Id", "Author", "CreatedDate", "Editor", "IsActive", "IsDeleted", "Multiplier", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6290), 0, false, false, 1f, "Kademe Yok", null },
                    { 2, 0, new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6292), 0, false, false, 1.232f, "4. Kademe", null },
                    { 3, 0, new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6293), 0, false, false, 1.15f, "3. Kademe", null },
                    { 4, 0, new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6293), 0, false, false, 1.077f, "2. Kademe", null },
                    { 5, 0, new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6294), 0, false, false, 1f, "1. Kademe", null },
                    { 6, 0, new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6295), 0, false, false, 1.287f, "En 4. Kademe", null },
                    { 7, 0, new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6296), 0, false, false, 1.19f, "En 3. Kademe", null },
                    { 8, 0, new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6296), 0, false, false, 1f, "En 2. Kademe", null },
                    { 9, 0, new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6297), 0, false, false, 1f, "En 1. Kademe", null },
                    { 10, 0, new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6299), 0, false, false, 1.378f, "Mek 3. Kademe", null },
                    { 11, 0, new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6366), 0, false, false, 1.159f, "Mek 2. Kademe", null },
                    { 12, 0, new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6368), 0, false, false, 1f, "Mek 1. Kademe", null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.InsertData(
                table: "Seniorities",
                columns: new[] { "Id", "Author", "CreatedDate", "Editor", "IsActive", "IsDeleted", "Multiplier", "Name", "UpdatedDate" },
                values: new object[] { 1, 0, new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6162), 0, false, false, 0f, "Şef Müdür", null });

            migrationBuilder.InsertData(
                table: "Seniorities",
                columns: new[] { "Id", "Author", "CreatedDate", "Editor", "IsActive", "IsDeleted", "Multiplier", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 2, 0, new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6174), 0, false, false, 0f, "Grup Lideri", null },
                    { 3, 0, new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6175), 0, false, false, 0f, "Takım Lideri", null },
                    { 4, 0, new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6176), 0, false, false, 13.5f, "Takım Lider Yardımcısı", null },
                    { 5, 0, new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6177), 0, false, false, 18.5f, "Operatör", null }
                });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.InsertData(
                table: "Absenteeism",
                columns: new[] { "Id", "AbsenteeismTypeId", "Author", "CreatedDate", "Editor", "EmployeeId", "EndDate", "IsActive", "IsDeleted", "StartDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 0, new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1322), 0, 1, new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 2, 0, new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1326), 0, 2, new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 3, 0, new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1328), 0, 3, new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 4, 0, new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1329), 0, 4, new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 5, 0, new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1330), 0, 5, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 6, 0, new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1331), 0, 6, new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "RankId", "RegistrationNo", "SeniorityId" },
                values: new object[] { new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6470), 1, "10001", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "RankId", "RegistrationNo", "SeniorityId" },
                values: new object[] { new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6474), 2, "10002", 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "RankId", "RegistrationNo", "SeniorityId" },
                values: new object[] { new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6476), 3, "10003", 3 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "RankId", "RegistrationNo", "SeniorityId" },
                values: new object[] { new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6478), 4, "10004", 4 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "RankId", "RegistrationNo", "SeniorityId" },
                values: new object[] { new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6479), 5, "10005", 5 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "RankId", "RegistrationNo", "SeniorityId" },
                values: new object[] { new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6480), 6, "10006", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RankId",
                table: "Employees",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SeniorityId",
                table: "Employees",
                column: "SeniorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Absenteeism_AbsenteeismTypeId",
                table: "Absenteeism",
                column: "AbsenteeismTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Absenteeism_EmployeeId",
                table: "Absenteeism",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Rank_RankId",
                table: "Employees",
                column: "RankId",
                principalTable: "Rank",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Seniorities_SeniorityId",
                table: "Employees",
                column: "SeniorityId",
                principalTable: "Seniorities",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Rank_RankId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Seniorities_SeniorityId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Absenteeism");

            migrationBuilder.DropTable(
                name: "Rank");

            migrationBuilder.DropTable(
                name: "Seniorities");

            migrationBuilder.DropTable(
                name: "AbsenteeismType");

            migrationBuilder.DropIndex(
                name: "IX_Employees_RankId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_SeniorityId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DateOfDismissal",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DateOfEmployment",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "RankId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "RegistrationNo",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SeniorityId",
                table: "Employees");

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

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 17, 15, 7, 40, 607, DateTimeKind.Local).AddTicks(5960));

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
        }
    }
}
