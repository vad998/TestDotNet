using Microsoft.EntityFrameworkCore;
using TestDotNet.Data.Models;

namespace TestDotNet.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<BusinessTrip> BusinessTrip { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Position> Position { get; set; }
    }
}