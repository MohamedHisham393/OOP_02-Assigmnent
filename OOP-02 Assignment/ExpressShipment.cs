using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OOP_02_Assignment
{

    internal class ExpressShipment :Shipment
    {
        
        private decimal _ExtraFee;

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
        public decimal ExtraFee
        {
            get { return _ExtraFee; }
            set 
            {
                if(value >=0)
                {
                    _ExtraFee = value;
                }
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + ExtraFee;
            }
        }

        public override string ShipmentType
        {
            get { return "Express Shipment"; }
        }

        protected override void PrintExtraDetails()
        {
            Console.WriteLine($"Extra Fee      : {ExtraFee} EGP");
        }
    }
}
