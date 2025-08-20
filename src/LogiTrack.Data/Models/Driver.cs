namespace LogiTrack.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static LogiTrack.Common.EntityValidationConstants.Driver;

    public class Driver
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(FirstNameMaxValue)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxValue)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = default!;

        public bool IsAvailable { get; set; } = true;

       
        public Guid? VehicleId { get; set; }

        public virtual Vehicle? Vehicle { get; set; }

        public virtual ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
    }
}
