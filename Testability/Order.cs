using System;

namespace Testability
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced;
        public Shipment Shipment;
        public float TotalPrice;

        public bool IsShipped
        {
            get { return Shipment != null; }
        }
    }
}