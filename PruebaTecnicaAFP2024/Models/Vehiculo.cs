namespace PruebaTecnicaAFP2024.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string NumeroPlaca { get; set; }
        public string Vin { get; set; }
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
        public string Serie { get; set; }
        public int Anio { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public int CantidadPuertas { get; set; }
    }
}
