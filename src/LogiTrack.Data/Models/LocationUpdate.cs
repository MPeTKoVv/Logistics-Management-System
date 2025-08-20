namespace LogiTrack.Data.Models
{
    public class LocationUpdate
    {
        public Guid Id { get; set; }

        public Guid ShipmentId { get; set; }
        
        public Shipment Shipment { get; set; } = null!;
        
        public string Location { get; set; } = null!;
        
        public DateTime RecordedAt { get; set; } = DateTime.UtcNow;
    }
}
