using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NTierECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 12, 26, 23, 18, 38, 694, DateTimeKind.Local).AddTicks(6146), new Guid("e7959be0-66dd-4170-b3eb-d7bbc61f8d6f") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 12, 26, 23, 18, 38, 694, DateTimeKind.Local).AddTicks(6234), new Guid("980c1eb1-3bda-4af9-b5ce-db2e154a337a") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 12, 26, 23, 18, 38, 694, DateTimeKind.Local).AddTicks(6237), new Guid("447d8d13-52d3-4196-ad7e-dd84e450d133") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 12, 26, 23, 18, 38, 694, DateTimeKind.Local).AddTicks(7681), new Guid("9e52edb2-bc93-483b-8a90-2f5fd61c5e29") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 12, 26, 23, 18, 38, 694, DateTimeKind.Local).AddTicks(7692), new Guid("80711a2c-256b-4eac-942f-204d94c99280") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 12, 26, 23, 18, 38, 694, DateTimeKind.Local).AddTicks(7694), new Guid("f102e9eb-04bb-4d06-b2e5-d9d605b16ef8") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 12, 26, 12, 14, 31, 666, DateTimeKind.Local).AddTicks(331), new Guid("a3eec1fc-4667-419f-ab0b-8b1ac8f93836") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 12, 26, 12, 14, 31, 666, DateTimeKind.Local).AddTicks(381), new Guid("f5de8235-7078-41a4-b16a-a0d953e8db5e") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 12, 26, 12, 14, 31, 666, DateTimeKind.Local).AddTicks(385), new Guid("60160a49-4a1b-46a7-8eea-1721f7f6bc18") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 12, 26, 12, 14, 31, 666, DateTimeKind.Local).AddTicks(3189), new Guid("c31c6b96-41fd-42c1-b45f-a58d7c54c379") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 12, 26, 12, 14, 31, 666, DateTimeKind.Local).AddTicks(3217), new Guid("7373bfbf-072f-4597-aa22-00aea34a1a74") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 12, 26, 12, 14, 31, 666, DateTimeKind.Local).AddTicks(3221), new Guid("9fc76efe-de22-4450-8802-6fc7f3238e28") });
        }
    }
}
