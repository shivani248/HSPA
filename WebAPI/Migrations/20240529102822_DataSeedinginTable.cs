using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class DataSeedinginTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 52, 37, 401, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 52, 37, 401, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 52, 37, 401, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 52, 37, 401, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 52, 37, 401, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 52, 37, 401, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 52, 37, 401, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 52, 37, 401, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2024, 5, 29, 15, 52, 37, 401, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 5, 29, 15, 52, 37, 401, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 52, 37, 401, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 52, 37, 401, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 52, 37, 401, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdateOn",
                value: new DateTime(2024, 5, 29, 15, 52, 37, 401, DateTimeKind.Local).AddTicks(5282));
        }
    }
}
