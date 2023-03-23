using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16ecc23e-2bc3-4699-9028-83cd0d2dc90c",
                column: "ConcurrencyStamp",
                value: "48eb1435-e4a6-4acc-98a9-5477a6bc47c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17ebc23e-2cc3-4699-9039-83cd0d2dc90c",
                column: "ConcurrencyStamp",
                value: "af583b9d-e5cb-4a9b-9932-ba5d227d3cb3");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4be57a5e-f90e-4661-9a08-f44fe8095737", 0, "f4c440c4-6766-4213-807b-579f3c72b379", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEDf3vNgZMy5tbDNAMrWiw4EK3/59g00B2D3J/8JQZvS0zA9AaIKCx5Zyl4xwtGErTg==", null, false, "15743c6b-5e2b-42c9-ba27-26dcaed8e5c7", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 11, 10, 734, DateTimeKind.Local).AddTicks(6222), new DateTime(2023, 3, 5, 15, 11, 10, 738, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 11, 10, 738, DateTimeKind.Local).AddTicks(6213), new DateTime(2023, 3, 5, 15, 11, 10, 738, DateTimeKind.Local).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 11, 10, 740, DateTimeKind.Local).AddTicks(2479), new DateTime(2023, 3, 5, 15, 11, 10, 740, DateTimeKind.Local).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 11, 10, 740, DateTimeKind.Local).AddTicks(2997), new DateTime(2023, 3, 5, 15, 11, 10, 740, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 11, 10, 740, DateTimeKind.Local).AddTicks(7971), new DateTime(2023, 3, 5, 15, 11, 10, 740, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 11, 10, 740, DateTimeKind.Local).AddTicks(8494), new DateTime(2023, 3, 5, 15, 11, 10, 740, DateTimeKind.Local).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 11, 10, 740, DateTimeKind.Local).AddTicks(8526), new DateTime(2023, 3, 5, 15, 11, 10, 740, DateTimeKind.Local).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 11, 10, 740, DateTimeKind.Local).AddTicks(8548), new DateTime(2023, 3, 5, 15, 11, 10, 740, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "17ebc23e-2cc3-4699-9039-83cd0d2dc90c", "4be57a5e-f90e-4661-9a08-f44fe8095737" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "17ebc23e-2cc3-4699-9039-83cd0d2dc90c", "4be57a5e-f90e-4661-9a08-f44fe8095737" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4be57a5e-f90e-4661-9a08-f44fe8095737");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16ecc23e-2bc3-4699-9028-83cd0d2dc90c",
                column: "ConcurrencyStamp",
                value: "911a4324-faa9-4f81-8768-686db5e2f792");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17ebc23e-2cc3-4699-9039-83cd0d2dc90c",
                column: "ConcurrencyStamp",
                value: "68915dff-4358-4102-8020-c6443ef51c07");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 14, 30, 28, 871, DateTimeKind.Local).AddTicks(4193), new DateTime(2023, 3, 5, 14, 30, 28, 875, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 14, 30, 28, 875, DateTimeKind.Local).AddTicks(3252), new DateTime(2023, 3, 5, 14, 30, 28, 875, DateTimeKind.Local).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 14, 30, 28, 877, DateTimeKind.Local).AddTicks(3615), new DateTime(2023, 3, 5, 14, 30, 28, 877, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 14, 30, 28, 877, DateTimeKind.Local).AddTicks(4160), new DateTime(2023, 3, 5, 14, 30, 28, 877, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 14, 30, 28, 877, DateTimeKind.Local).AddTicks(9249), new DateTime(2023, 3, 5, 14, 30, 28, 877, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 14, 30, 28, 877, DateTimeKind.Local).AddTicks(9766), new DateTime(2023, 3, 5, 14, 30, 28, 877, DateTimeKind.Local).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 14, 30, 28, 877, DateTimeKind.Local).AddTicks(9797), new DateTime(2023, 3, 5, 14, 30, 28, 877, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 14, 30, 28, 877, DateTimeKind.Local).AddTicks(9819), new DateTime(2023, 3, 5, 14, 30, 28, 877, DateTimeKind.Local).AddTicks(9829) });
        }
    }
}
