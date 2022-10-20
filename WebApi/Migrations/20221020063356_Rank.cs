using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class Rank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Rank_RankId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rank",
                table: "Rank");

            migrationBuilder.RenameTable(
                name: "Rank",
                newName: "Ranks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ranks",
                table: "Ranks",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Absenteeism",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "Absenteeism",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Absenteeism",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Absenteeism",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Absenteeism",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Absenteeism",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "AbsenteeismType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "AbsenteeismType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "AbsenteeismType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "AbsenteeismType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "AbsenteeismType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "AbsenteeismType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "AbsenteeismType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 353, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Seniorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "Seniorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Seniorities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Seniorities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Seniorities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 33, 55, 349, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Ranks_RankId",
                table: "Employees",
                column: "RankId",
                principalTable: "Ranks",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Ranks_RankId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ranks",
                table: "Ranks");

            migrationBuilder.RenameTable(
                name: "Ranks",
                newName: "Rank");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rank",
                table: "Rank",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Absenteeism",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Absenteeism",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Absenteeism",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Absenteeism",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Absenteeism",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Absenteeism",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "AbsenteeismType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "AbsenteeismType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "AbsenteeismType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "AbsenteeismType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "AbsenteeismType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "AbsenteeismType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "AbsenteeismType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 954, DateTimeKind.Local).AddTicks(1236));

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
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6480));

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

            migrationBuilder.UpdateData(
                table: "Rank",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Rank",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Rank",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Rank",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Rank",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Rank",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Rank",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Rank",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Rank",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Rank",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Rank",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "Rank",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6368));

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

            migrationBuilder.UpdateData(
                table: "Seniorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Seniorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "Seniorities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Seniorities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "Seniorities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 9, 15, 16, 949, DateTimeKind.Local).AddTicks(6177));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Rank_RankId",
                table: "Employees",
                column: "RankId",
                principalTable: "Rank",
                principalColumn: "Id");
        }
    }
}
