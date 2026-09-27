using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_02_Assignment
{
    internal class InternationalShipment : Shipment
    {
        private string _DestinationCountry;
        private decimal _CustomsFee;

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public string DestinationCountry
        {
            get { return _DestinationCountry; }
            set 
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    _DestinationCountry = value;
                }
            }
        }

        public decimal CustomsFee
        {
            get { return _CustomsFee; }
            set 
            {
                if (value >= 0)
                {
                    _CustomsFee = value;
                }
            }
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + CustomsFee; }
        }

        public override string ShipmentType
        {
            get { return "International Shipment"; }
        }
        protected override void PrintExtraDetails()
        {
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee         : {CustomsFee} EGP");
        }
    }
}
