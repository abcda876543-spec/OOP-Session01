using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Session01
{
    public struct Shipment
    {
        private string trackingCode;
        private double weight;
        private decimal deliveryFee;
        public DeliveryAddress Destination { get; set; }
        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }
        }
        public string Description { get; set; }

        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if (value > 0)
                    weight = value;
            }
        }
        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
        }
        public decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)Weight * 5;
            }
        }
        public Shipment(string code, string description, double w, decimal fee, DeliveryAddress address)
        {
            trackingCode = code;
            Description = description;
            weight = w;
            deliveryFee = fee;
            Destination = address;
        }

        public Shipment(string trackingCode)
    : this(trackingCode, "Unknown", 1, 50,
          new DeliveryAddress("Unknown", "Unknown", 0))
        {
        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }

        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }
    }




}

