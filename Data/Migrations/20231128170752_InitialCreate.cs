using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    contact_name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    Birth = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Birth", "Email", "contact_name", "Phone" },
                values: new object[] { 1, null, "test@wsei.edu.pl", "Test", "123456789" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Birth", "Email", "contact_name", "Phone" },
                values: new object[] { 2, new DateTime(200, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "adam@wsei.edu.pl", "Adam", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
