using Microsoft.EntityFrameworkCore;
using RealTimeCommunicationApp.DAL.DbContexts;
using RealTimeCommunicationApp.Services.Interfaces;

namespace RealTimeCommunicationApp.Services.Implementations
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class , new()
    {
        private readonly DbContext _context;
        private IGenericRepo<T> _genericRepo;

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public IGenericRepo<T> GenericRepo => _genericRepo ??= new GenericRepo<T>(_context);
 
        public async void Commit()
        {
             await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

