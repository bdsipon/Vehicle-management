using Microsoft.EntityFrameworkCore;
using Vehicle_management.models;

namespace Vehicle_management.Persistence
{
    public class VehicleDbContext:DbContext
    {
        public VehicleDbContext(DbContextOptions<VehicleDbContext> options):base(options)
        {
           
        }
         public DbSet<Make> Makes { get; set; }
         public DbSet<Feature> Features { get; set; }
        
    }
}