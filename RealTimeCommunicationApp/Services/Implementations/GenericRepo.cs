using Microsoft.EntityFrameworkCore;
using RealTimeCommunicationApp.Services.Interfaces;
using System.Linq.Expressions;

namespace RealTimeCommunicationApp.Services.Implementations
{
    public class GenericRepo<TEntity> : IGenericRepo<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public GenericRepo(DbContext dbContext)
        {
            _context = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }
        public async Task<int> InsertAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            return await _context.SaveChangesAsync();
        }
        public async Task<TEntity> GetByIDAsync(int id)
        {
            return await _dbSet.FindAsync(id) ?? throw new Exception($"No user with Id : {id} found.");
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity , bool>>? filter = null)
        {
            if(filter == null)
            {
                return await _dbSet.ToListAsync();
            }
            else
            {
                return await _dbSet.Where(filter).ToListAsync();
            }
        }

        public async void UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
           await _context.SaveChangesAsync();
        }
    }
}
