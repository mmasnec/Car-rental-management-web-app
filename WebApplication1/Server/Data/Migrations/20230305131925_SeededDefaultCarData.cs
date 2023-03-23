using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 3, 5, 14, 19, 24, 850, DateTimeKind.Local).AddTicks(8403), new DateTime(2023, 3, 5, 14, 19, 24, 855, DateTimeKind.Local).AddTicks(1357), "Black", "System" },
                    { 2, "System", new DateTime(2023, 3, 5, 14, 19, 24, 855, DateTimeKind.Local).AddTicks(2788), new DateTime(2023, 3, 5, 14, 19, 24, 855, DateTimeKind.Local).AddTicks(2808), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(514), new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(564), "Toyota", "System" },
                    { 2, "System", new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(1055), new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(1073), "Mazda", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(5820), new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(5858), "Prius", "System" },
                    { 2, "System", new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(6324), new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(6343), "Corolla", "System" },
                    { 3, "System", new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(6355), new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(6365), "X5", "System" },
                    { 4, "System", new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(6376), new DateTime(2023, 3, 5, 14, 19, 24, 857, DateTimeKind.Local).AddTicks(6387), "Series 3", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
