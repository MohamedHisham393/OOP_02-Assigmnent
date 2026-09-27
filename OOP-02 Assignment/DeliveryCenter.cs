using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace OOP_02_Assignment
{
    internal class DeliveryCenter
    {
        private Shipment[] _shipments;
        string _CenterName;
        public DeliveryCenter(string centername)
        {
            _shipments = new Shipment[20];
            CenterName = centername;
        }

        public string CenterName
        {
            get { return _CenterName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _CenterName = value;
                }
            }
        }

        public Shipment this[int index]
        {
            get
            {
                if (index < _shipments.Length && index >= 0)
                {
                    return _shipments[index];
                }
                else
                {
                    return default;
                }
            }

            set
            {
                if (index < _shipments.Length && index >= 0)
                {
                    _shipments[index] = value;
                }
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < _shipments.Length; i++)
                {
                    if (_shipments[i] != null && trackingCode == _shipments[i].TrackingCode)
                    {
                        return _shipments[i];
                    }
                }
                return default;
            }
        }

        public bool AddShipment(Shipment ship)
        {
            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i] == null)
                {
                    _shipments[i] = ship;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for(int i =0 ; i < _shipments.Length;i++)
            {
                if (_shipments[i] != null && trackingCode == _shipments[i].TrackingCode)
                {
                    _shipments[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"Delivery Center : {CenterName}");
            Console.WriteLine("=========================================");
            Console.WriteLine();

            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i] != null)
                {
                    _shipments[i].PrintShipment();
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------");
                }
            }
        }
    }
}
