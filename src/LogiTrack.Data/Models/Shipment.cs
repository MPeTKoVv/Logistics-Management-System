namespace LogiTrack.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.Shipment;

    public class Shipment
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(OriginAddressMaxValue)]
        public string OriginAddress { get; set; } = null!;

        [Required]
        [MaxLength(DestinationAddressMaxValue)]
        public string DestinationAddress { get; set; } = null!;

        public ShipmentStatus Status { get; set; } = ShipmentStatus.Pending;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public string? AssignedDriverId { get; set; }
        public virtual Driver? AssignedDriver { get; set; }

        public virtual ICollection<LocationUpdate> LocationUpdates { get; set; } = new List<LocationUpdate>();
    }
}
