using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Interfastructures.Migrations
{
    /// <inheritdoc />
    public partial class sss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Airline",
                table: "Planes",
                newName: "Airlinelogo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Airlinelogo",
                table: "Planes",
                newName: "Airline");
        }
    }
}
