using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PruebaTecnicaAFP2024.Migrations
{
    /// <inheritdoc />
    public partial class AddVehiculos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vehiculos",
                columns: new[] { "Id", "Anio", "CantidadPuertas", "ColorId", "MarcaId", "NumeroPlaca", "Serie", "Vin" },
                values: new object[,]
                {
                    { 1, 2022, 4, 1, 1, "ABC123", "123456", "1HGCM82633A000001" },
                    { 2, 2023, 2, 2, 2, "XYZ789", "789012", "2T2BK1BA0FC123456" },
                    { 3, 2021, 4, 4, 3, "DEF456", "345678", "JTEBU5JR1G5135793" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehiculos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehiculos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehiculos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
