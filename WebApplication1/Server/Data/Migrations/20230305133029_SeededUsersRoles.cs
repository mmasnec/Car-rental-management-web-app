using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Server.Data.Migrations
{
    public partial class SeededUsersRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16ecc23e-2bc3-4699-9028-83cd0d2dc90c", "911a4324-faa9-4f81-8768-686db5e2f792", "User", "USER" },
                    { "17ebc23e-2cc3-4699-9039-83cd0d2dc90c", "68915dff-4358-4102-8020-c6443ef51c07", "Administrator", "ADMINISTRATOR" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16ecc23e-2bc3-4699-9028-83cd0d2dc90c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17ebc23e-2cc3-4699-9039-83cd0d2dc90c");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 14, 19, 24, 850, DateTimeKind.Local).AddTicks(8403), new DateTime(2023, 3, 5, 14, 19, 24, 855, DateTimeKind.Local).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 14, 19, 24, 855, DateTimeKind.Local).AddTicks(2788), new DateTime(2023, 3, 5, 14, 19, 24, 855, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(514), new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(1055), new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(5820), new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(6324), new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(6355), new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(6376), new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(6387) });
        }
    }
}
