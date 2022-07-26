namespace shipping_backend.Models
{
    public class Shipment
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public string OrderDate { get; set; }
        public string ShipFrom { get; set; }
        public string ShipTo { get; set; }
        public string OrderStatus { get; set; }
        public string Description { get; set; }
    }
}