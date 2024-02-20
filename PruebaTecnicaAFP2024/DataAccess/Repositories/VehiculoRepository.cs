using Microsoft.EntityFrameworkCore;
using PruebaTecnicaAFP2024.DataAccess.Core;
using PruebaTecnicaAFP2024.Models;

namespace PruebaTecnicaAFP2024.DataAccess.Repositories
{
    public class VehiculoRepository : Repository<Vehiculo>,IVehiculoRepository
    {
        private AppDbContext AppDbContext => (Context as AppDbContext)!;
        public VehiculoRepository(DbContext context) : base(context)
        {

        }


        public override async Task<Vehiculo> GetAsync(int id)
        {
            return (await AppDbContext.Vehiculos.FirstOrDefaultAsync(v => v.Id == id))!;
        }

        public override async Task<IEnumerable<Vehiculo>> GetAllAsync()
        {
            return await AppDbContext.Vehiculos
                .Include(v => v.Marca)
                .Include(v => v.Color)
                .ToListAsync();
        }
    }
}
