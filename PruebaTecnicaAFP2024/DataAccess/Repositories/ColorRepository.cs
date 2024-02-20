using Microsoft.EntityFrameworkCore;
using PruebaTecnicaAFP2024.DataAccess.Core;
using PruebaTecnicaAFP2024.Models;

namespace PruebaTecnicaAFP2024.DataAccess.Repositories
{
    public class ColorRepository : Repository<Color>, IColorRepository
    {
        public ColorRepository(DbContext context) : base(context)
        {
        }
    }
}
