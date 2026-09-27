using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_02_Assignment
{
    internal class Shipment
    {
        private string _TrackingCode;
        private string _Description;
        private decimal _Weight;
        private decimal _DeliveryFee;

        public DeliveryAddress Destination { get; set; }

        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress();
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public string TrackingCode
        {
            get { return _TrackingCode; }

            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _TrackingCode = value;
                }
            }
        }


        public string Description
        {
            get { return _Description; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _Description = value;
                }
            }
        }


        public decimal Weight
        {
            get { return _Weight; }
            set
            {
                if (value > 0)
                {
                    _Weight = value;
                }
            }
        }


        public decimal DeliveryFee
        {
            get { return _DeliveryFee; }

            private set
            {
                if (value > 0)
                {
                    _DeliveryFee = value;
                }
            }
        }


        public virtual decimal EstimatedCost
        {
            get { return _DeliveryFee + (_Weight * 5); }
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                _DeliveryFee = newFee;
            }

        }
        public virtual string ShipmentType
        {
            get { return "Standard Shipment"; }
        }

        protected virtual void PrintExtraDetails()
        {
             
        }
        public virtual void PrintShipment()
        {
            Console.WriteLine(ShipmentType);
            Console.WriteLine();
            Console.WriteLine($"Tracking Code : {_TrackingCode}");
            Console.WriteLine($"Description : {_Description}");
            Console.WriteLine($"Weight : {_Weight} KG");
            Console.WriteLine($"Delivery fee : {_DeliveryFee} EGP");
            PrintExtraDetails();
            //Console.WriteLine($"Destination : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
        }
    }
}
