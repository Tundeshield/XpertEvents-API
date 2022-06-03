using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XpertEventsApi.Migrations
{
    public partial class seededEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Events");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Wedding" },
                    { 2, "Naming Ceremony" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Name", "password" },
                values: new object[,]
                {
                    { 1, "Tunde Adepegba", "chemicals" },
                    { 2, "Smita Pandya", "projectManagement" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CategoryId", "CustomerId", "Date", "Description", "EventTitle" },
                values: new object[] { 1, 1, 2, new DateTime(2022, 6, 3, 12, 27, 36, 677, DateTimeKind.Local).AddTicks(5343), "You are specially invited to the holy matrimony of Bukola and Tunde Adepegba on the 31st of may, 2023", "Bukola's wedding" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CategoryId", "CustomerId", "Date", "Description", "EventTitle" },
                values: new object[] { 2, 1, 1, new DateTime(2022, 6, 3, 12, 27, 36, 677, DateTimeKind.Local).AddTicks(5384), "You are specially invited to the Naming Ceremony and marriage of tayo, 2023", "Tayo's wedding" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
