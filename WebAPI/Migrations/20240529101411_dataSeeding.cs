using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class dataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ISellRent",
                table: "Properties",
                newName: "SellRent");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedBy",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Country", "LastUpdateOn", "LastUpdatedBy", "Name" },
                values: new object[,]
                {
                    { 4, "USA", new DateTime(2024, 5, 29, 15, 44, 10, 88, DateTimeKind.Local).AddTicks(2144), 11, "New York" },
                    { 5, "USA", new DateTime(2024, 5, 29, 15, 44, 10, 88, DateTimeKind.Local).AddTicks(2147), 22, "Houston" },
                    { 6, "USA", new DateTime(2024, 5, 29, 15, 44, 10, 88, DateTimeKind.Local).AddTicks(2149), 33, "Los Angeles" },
                    { 7, "India", new DateTime(2024, 5, 29, 15, 44, 10, 88, DateTimeKind.Local).AddTicks(2151), 44, "New Delhi" },
                    { 8, "India", new DateTime(2024, 5, 29, 15, 44, 10, 88, DateTimeKind.Local).AddTicks(2154), 55, "Bangalore" }
                });

            migrationBuilder.InsertData(
                table: "FurnishingTypes",
                columns: new[] { "Id", "LastUpdateOn", "LastUpdatedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 29, 15, 44, 10, 88, DateTimeKind.Local).AddTicks(2106), 1, "Fully" },
                    { 2, new DateTime(2024, 5, 29, 15, 44, 10, 88, DateTimeKind.Local).AddTicks(2109), 1, "Semi" },
                    { 3, new DateTime(2024, 5, 29, 15, 44, 10, 88, DateTimeKind.Local).AddTicks(2111), 1, "Unfurnished" }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "LastUpdateOn", "LastUpdatedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 29, 15, 44, 10, 88, DateTimeKind.Local).AddTicks(2060), 1, "House" },
                    { 2, new DateTime(2024, 5, 29, 15, 44, 10, 88, DateTimeKind.Local).AddTicks(2063), 1, "Apartment" },
                    { 3, new DateTime(2024, 5, 29, 15, 44, 10, 88, DateTimeKind.Local).AddTicks(2065), 1, "Duplex" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "LastUpdateOn", "LastUpdatedBy", "Password", "PasswordKey", "Name" },
                values: new object[] { 2, new DateTime(2024, 5, 29, 15, 44, 10, 88, DateTimeKind.Local).AddTicks(1650), 0, new byte[] { 104, 97, 115, 104, 101, 100, 95, 112, 97, 115, 115, 119, 111, 114, 100 }, new byte[] { 104, 97, 115, 104, 101, 100, 95, 112, 97, 115, 115, 119, 111, 114, 100, 95, 107, 101, 121 }, "Demo" });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "Address", "Address2", "Age", "BHK", "BuiltArea", "CarpetArea", "CityId", "Description", "EstPossessionOn", "FloorNo", "FurnishingTypeId", "Gated", "MainEntrance", "Maintenance", "Name", "PostedBy", "PostedOn", "Price", "PropertyTypeId", "ReadyToMove", "Security", "SellRent", "TotalFloors" },
                values: new object[,]
                {
                    { 1, "6 Street", "Golf Course Road", 0, 2, 1400, 900, 1, "Well Maintained builder floor available for rent at prime location...", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, true, "East", 300, "White House Demo", 1, new DateTime(2024, 5, 29, 15, 44, 10, 88, DateTimeKind.Local).AddTicks(2212), 1800, 2, true, 0, 1, 3 },
                    { 2, "6 Street", "Golf Course Road", 0, 2, 1400, 900, 1, "Well Maintained builder floor available for rent at prime location...", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, true, "East", 300, "Birla House Demo", 1, new DateTime(2024, 5, 29, 15, 44, 10, 88, DateTimeKind.Local).AddTicks(2219), 1800, 2, true, 0, 2, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FurnishingTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "LastUpdateOn",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "SellRent",
                table: "Properties",
                newName: "ISellRent");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
