using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EStoreAdminRepository.Migrations.TypeRepositoryMigrations
{
    /// <inheritdoc />
    public partial class TypesMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("165dc7d9-023f-486d-bf49-efbb5b497edc"), "Gadgets" },
                    { new Guid("2df9493d-b9cb-44fc-80b6-496ea679dc0d"), "Mobile" },
                    { new Guid("7be12499-133e-4290-a652-666a5a7fe387"), "Television" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
