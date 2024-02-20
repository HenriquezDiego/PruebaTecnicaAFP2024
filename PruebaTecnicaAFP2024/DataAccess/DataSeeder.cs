using PruebaTecnicaAFP2024.Models;

namespace PruebaTecnicaAFP2024.DataAccess
{
    public class DataSeeder
    {
        public static List<Marca> Marcas => new()
        {
            new Marca { Id = 1, Nombre = "Toyota" },
            new Marca { Id = 2, Nombre = "Honda" },
            new Marca { Id = 3, Nombre = "Ford" },
            new Marca { Id = 4, Nombre = "Chevrolet" },
            new Marca { Id = 5, Nombre = "Nissan" },
            new Marca { Id = 7, Nombre = "BMW" },
            new Marca { Id = 8, Nombre = "Mercedes-Benz" },
            new Marca { Id = 9, Nombre = "Audi" },
            new Marca { Id = 10, Nombre = "Hyundai" },
        };

        public static List<Color> Colores => new()
        {
            new Color { Id = 1, Nombre = "Rojo" },
            new Color { Id = 2, Nombre = "Azul" },
            new Color { Id = 4, Nombre = "Blanco" },
            new Color { Id = 5, Nombre = "Negro" },
            new Color { Id = 6, Nombre = "Gris" },
        };

        public static List<Vehiculo> Vehiculos => new()
        {
            new Vehiculo { Id = 1, NumeroPlaca = "ABC123", 
                Vin = "1HGCM82633A000001", 
                MarcaId = 1, 
                Serie = "123456", 
                Anio = 2022, 
                ColorId = 1, 
                CantidadPuertas = 4
            },
            new Vehiculo { Id = 2, NumeroPlaca = "XYZ789", 
                Vin = "2T2BK1BA0FC123456", 
                MarcaId = 2, 
                Serie = "789012", 
                Anio = 2023, 
                ColorId = 2, 
                CantidadPuertas = 2
            },
            new Vehiculo { Id = 3, NumeroPlaca = "DEF456", 
                Vin = "JTEBU5JR1G5135793", 
                MarcaId = 3, 
                Serie = "345678", 
                Anio = 2021, 
                ColorId = 4,
                CantidadPuertas = 4
            },
        };
    }
}
