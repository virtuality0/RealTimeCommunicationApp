using System.Linq.Expressions;

namespace RealTimeCommunicationApp.Services.Interfaces
{
    public interface IGenericRepo<TEntity> where TEntity : class
    {
        public Task<TEntity> GetByIDAsync(int id);
        public Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null);
        public Task<int> InsertAsync(TEntity entity);
        public void UpdateAsync(TEntity entity);
    }
}
