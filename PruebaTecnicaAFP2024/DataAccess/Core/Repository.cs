using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace PruebaTecnicaAFP2024.DataAccess.Core
{
    public class Repository<TEntity>  : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        private readonly DbSet<TEntity> _dbSet;

        protected Repository(DbContext context)
        {
            Context = context;
            _dbSet = context.Set<TEntity>();

        }
        public virtual TEntity Get(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {

            return _dbSet.ToList();
        }

        public virtual async Task<TEntity> GetAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public bool Complete()
        {
            return Context.SaveChanges() > 0;
        }
    }
}
