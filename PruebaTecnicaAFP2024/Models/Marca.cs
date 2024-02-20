using System.Security.Principal;

namespace PruebaTecnicaAFP2024.Models
{
    public class Marca
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public IEnumerable<Vehiculo> Vehiculos { get; set; }
    }
}
