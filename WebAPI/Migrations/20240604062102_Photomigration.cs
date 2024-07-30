using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Photomigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PublicId",
                table: "Photos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 4, 11, 51, 0, 969, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 4, 11, 51, 0, 969, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 4, 11, 51, 0, 969, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 4, 11, 51, 0, 969, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 4, 11, 51, 0, 969, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 4, 11, 51, 0, 969, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 4, 11, 51, 0, 969, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 4, 11, 51, 0, 969, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastUpdateOn", "PostedOn" },
                values: new object[] { new DateTime(2024, 6, 4, 11, 51, 0, 969, DateTimeKind.Local).AddTicks(8669), new DateTime(2024, 6, 4, 11, 51, 0, 969, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastUpdateOn", "PostedOn" },
                values: new object[] { new DateTime(2024, 6, 4, 11, 51, 0, 969, DateTimeKind.Local).AddTicks(8693), new DateTime(2024, 6, 4, 11, 51, 0, 969, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 4, 11, 51, 0, 969, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 4, 11, 51, 0, 969, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 4, 11, 51, 0, 969, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 6, 4, 11, 51, 0, 969, DateTimeKind.Local).AddTicks(8183));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicId",
                table: "Photos");

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
                columns: new[] { "LastUpdateOn", "PostedOn" },
                values: new object[] { new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(9196), new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastUpdateOn", "PostedOn" },
                values: new object[] { new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(9212), new DateTime(2024, 6, 3, 12, 27, 40, 55, DateTimeKind.Local).AddTicks(9216) });

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
    }
}
