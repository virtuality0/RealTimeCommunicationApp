using Microsoft.EntityFrameworkCore;
using RealTimeCommunicationApp.DAL.Entities;

namespace RealTimeCommunicationApp.DAL.DbContexts
{
    public class ApDbContext :  DbContext
    {
        public ApDbContext(DbContextOptions<ApDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
