using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class DataSeedingUpdateForUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 58, 21, 355, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 58, 21, 355, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 58, 21, 355, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 58, 21, 355, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 58, 21, 355, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 58, 21, 355, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 58, 21, 355, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 58, 21, 355, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2024, 5, 29, 15, 58, 21, 355, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 5, 29, 15, 58, 21, 355, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 58, 21, 355, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 58, 21, 355, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 58, 21, 355, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 58, 21, 355, DateTimeKind.Local).AddTicks(114));
        }
    }
}
