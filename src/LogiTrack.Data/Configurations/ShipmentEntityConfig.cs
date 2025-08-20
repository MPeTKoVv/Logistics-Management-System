namespace LogiTrack.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    
    using LogiTrack.Data.Models;

    public class ShipmentEntityConfig : IEntityTypeConfiguration<Shipment>
    {
        public void Configure(EntityTypeBuilder<Shipment> builder)
        {
            builder
                .HasMany(sh => sh.LocationUpdates)
                .WithOne(lp => lp.Shipment)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
