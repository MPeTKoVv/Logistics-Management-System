namespace LogiTrack.Data
{
    using LogiTrack.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Reflection;

    public class LogiTrackDbContext : DbContext
    {
        public LogiTrackDbContext(DbContextOptions<LogiTrackDbContext> options)
            : base(options)
        {

        }

        public DbSet<Driver> Drivers { get; set; } = null!;
        public DbSet<LocationUpdate> LocationUpdates { get; set; } = null!;
        public DbSet<Shipment> Shipments { get; set; } = null!;
        public DbSet<Vehicle> Vehicles { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssebly = Assembly.GetAssembly(typeof(LogiTrackDbContext)) ??
                                      Assembly.GetExecutingAssembly();
                
            builder.ApplyConfigurationsFromAssembly(configAssebly);

            base.OnModelCreating(builder);
        }

    }
}

