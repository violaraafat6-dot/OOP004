using System;
using System.Collections.Generic;
using System.Text;

#region Shipment

namespace OOP004
{
    public abstract class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;

        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get { return trackingCode; }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        public abstract decimal EstimatedCost { get; }

        public Shipment(string trackingCode)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
                this.trackingCode = trackingCode;

            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }

        public Shipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
                this.trackingCode = trackingCode;

            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }

        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
                Weight = newWeight;
        }

        public void UpdateWeight(decimal newWeight, decimal packingWeight)
        {
            if (newWeight > 0 && packingWeight >= 0)
                Weight = newWeight + packingWeight;
        }

        public abstract void PrintShipment();
    }
}



#endregion