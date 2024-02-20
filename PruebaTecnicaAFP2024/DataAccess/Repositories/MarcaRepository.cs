using Microsoft.EntityFrameworkCore;
using PruebaTecnicaAFP2024.DataAccess.Core;
using PruebaTecnicaAFP2024.Models;

namespace PruebaTecnicaAFP2024.DataAccess.Repositories
{
    public class MarcaRepository : Repository<Marca>,IMarcaRepository
    {
        public MarcaRepository(DbContext context) : base(context)
        {
        }
    }
}
