namespace LogiTrack.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using LogiTrack.Data.Models;

    public class DriverEntityConfig : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder
                .HasMany(d => d.Shipments)
                .WithOne(sh => sh.AssignedDriver)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(d => d.Vehicle)
                .WithOne(v => v.Driver)
                .HasForeignKey<Driver>(d => d.VehicleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
