using Microsoft.EntityFrameworkCore;
using Vehicle_management.models;

namespace Vehicle_management.Persistence
{
    public class VehicleDbContext:DbContext
    {
        public DbSet<Vehicle> Vehicles{get;set;}
         public DbSet<Make> Makes { get; set; }
         public DbSet<Feature> Features { get; set; }
        public VehicleDbContext(DbContextOptions<VehicleDbContext> options):base(options)
        {
           
        }
        

         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             modelBuilder.Entity<VehicleFeature>().HasKey(vf=>
             new{vf.VehicleId,vf.FeatureId});

         }
        
    }
}