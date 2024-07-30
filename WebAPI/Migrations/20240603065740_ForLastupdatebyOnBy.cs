using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class ForLastupdatebyOnBy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateOn",
                table: "Properties",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedBy",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastUpdateOn", "LastUpdatedBy", "PostedOn" },
                values: new object[] { new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(9196), 0, new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastUpdateOn", "LastUpdatedBy", "PostedOn" },
                values: new object[] { new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(9212), 0, new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(8961));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdateOn",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "Properties");

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
        }
    }
}
