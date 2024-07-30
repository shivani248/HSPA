using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForMakingNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
              name: "FK_Properties_Users_PostedBy",
                table: "Properties");

            migrationBuilder.AlterColumn<int>(
                name: "TotalFloors",
                table: "Properties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Security",
                table: "Properties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PostedBy",
                table: "Properties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Maintenance",
                table: "Properties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "Gated",
                table: "Properties",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "CarpetArea",
                table: "Properties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Properties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 31, 17, 48, 5, 567, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 31, 17, 48, 5, 567, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 31, 17, 48, 5, 567, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 31, 17, 48, 5, 567, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 31, 17, 48, 5, 567, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 31, 17, 48, 5, 567, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 31, 17, 48, 5, 567, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 31, 17, 48, 5, 567, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2024, 5, 31, 17, 48, 5, 567, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 5, 31, 17, 48, 5, 567, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 31, 17, 48, 5, 567, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 31, 17, 48, 5, 567, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 31, 17, 48, 5, 567, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 31, 17, 48, 5, 567, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Users_PostedBy",
                table: "Properties",
                column: "PostedBy",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Users_PostedBy",
                table: "Properties");

            migrationBuilder.AlterColumn<int>(
                name: "TotalFloors",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Security",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PostedBy",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Maintenance",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Gated",
                table: "Properties",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarpetArea",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 16, 0, 55, 669, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 16, 0, 55, 669, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 16, 0, 55, 669, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 16, 0, 55, 669, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 16, 0, 55, 669, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 16, 0, 55, 669, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 16, 0, 55, 669, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 16, 0, 55, 669, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2024, 5, 29, 16, 0, 55, 669, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 5, 29, 16, 0, 55, 669, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 16, 0, 55, 669, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 16, 0, 55, 669, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 16, 0, 55, 669, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 16, 0, 55, 669, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Users_PostedBy",
                table: "Properties",
                column: "PostedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
