namespace LogiTrack.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Common.EntityValidationConstants.Vehicle;

    public class Vehicle
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(BrandMaxLength)]
        public string Brand { get; set; } = null!;
        
        [Required]
        [MaxLength(ModelMaxLength)]
        public string Model { get; set; } = null!;

        public int yearOfProduction { get; set; }

        public double CapacityKg { get; set; }

        [Required]
        [MaxLength(PlateNumberMaxValue)]
        public string PlateNumber { get; set; } = null!;

        public string? DriverId { get; set; }

        public virtual Driver? Driver { get; set; }
    }
}
