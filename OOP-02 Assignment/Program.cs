namespace OOP_02_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 01 : Theoretical Questions

            //Q1
            //a)
            //Struct is value type, so when we copy we got a complete different object, any changes on one of them doesnt affect on the other object
            //Class is reference type, so when we copy we got two object refers to the same object in heap, any changes on one object it affects on the other object

            //Struct cannot be null but class can

            //Struct stored at stack so its faster to access it
            //Class stored at heap so it can carry more data

            //Struct always has the parameterless constructor even i made parameterizrd constructor
            //in Class the default parameterless constructor dissappears when i define any constructor

            //b)
            //if i have object wuth large data like (strings, numbers), every time i copy it with struct it copies a full copy with all data
            //but with class it only copies the reference so the program willnot be slow

            //Struct doesnt support inheritance

            //limited stack space if im using struct


            //Q2
            //a) Shipment is the parent class
            //b) ExpressShipment is the child class 
            //c) ExpressShipment inherits TrackingCode property
            //d) Less code to maintain - using less memory - repeating code is not good in programming

            //====================================================================

            //Practical part
            Console.WriteLine("Enter Delivery Center Name :");
            string Centername = Console.ReadLine();

            DeliveryCenter center = new DeliveryCenter(Centername);

            Console.WriteLine("\n--- Standard Shipment ---");

            Console.Write("Tracking Code: ");
            string trackingCode1 = Console.ReadLine();

            Console.Write("Description: ");
            string description1 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight1 = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal fee1 = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city1 = Console.ReadLine();

            Console.Write("Street: ");
            string street1 = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNum1 = int.Parse(Console.ReadLine());

            DeliveryAddress address1 = new DeliveryAddress(city1, street1, buildingNum1);

            StandardShipment standardShipment = new StandardShipment(trackingCode1, description1, weight1, fee1, address1);

            Console.WriteLine("\n");

            Console.WriteLine("\n--- Express Shipment ---");

            Console.Write("Tracking Code: ");
            string trackingCode2 = Console.ReadLine();

            Console.Write("Description: ");
            string description2 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight2 = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal fee2 = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city2 = Console.ReadLine();

            Console.Write("Street: ");
            string street2 = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNum2 = int.Parse(Console.ReadLine());

            Console.Write("Extra Fee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine());

            DeliveryAddress address2 = new DeliveryAddress(city2, street2, buildingNum2);

            ExpressShipment expressShipment = new ExpressShipment(trackingCode2, description2, weight2, fee2, address2, extraFee);

            Console.WriteLine("\n");

            Console.WriteLine("\n--- International Shipment ---");

            Console.Write("Tracking Code: ");
            string trackingCode3 = Console.ReadLine();

            Console.Write("Description: ");
            string description3 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight3 = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal fee3 = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city3 = Console.ReadLine();

            Console.Write("Street: ");
            string street3 = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNum3 = int.Parse(Console.ReadLine());

            Console.Write("Destination Country: ");
            string destinationCountry = Console.ReadLine();

            Console.Write("Customs Fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine());

            DeliveryAddress address3 = new DeliveryAddress(city3, street3, buildingNum3);

            InternationalShipment internationalShipment = new InternationalShipment(trackingCode3, description3, weight3, fee3, address3, destinationCountry, customsFee);

            if(center.AddShipment(standardShipment))
            {
                Console.WriteLine("Shipment Added Successfully");
            }
            if (center.AddShipment(expressShipment))
            {
                Console.WriteLine("Shipment Added Successfully");
            }
            if (center.AddShipment(internationalShipment))
            {
                Console.WriteLine("Shipment Added Successfully");
            }

            center.PrintAllShipments();

            Console.WriteLine();
            Console.Write("Enter Tracking Code to Search: ");
            string searchCode = Console.ReadLine();

            Shipment foundShipment = center[searchCode];

            if (foundShipment != null)
            {
                Console.WriteLine("\nShipment Found:");
                foundShipment.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment Not Found.");
            }

            
            Console.Write("Enter Tracking Code to Remove: ");
            string removeCode = Console.ReadLine();

            bool removed = center.RemoveShipment(removeCode);

            if (removed)
            {
                Console.WriteLine("\nShipment Removed Successfully.");
            }
            else
            {
                Console.WriteLine("\nShipment Not Found.");
            }

            Console.WriteLine();
            Console.WriteLine("=========================================");
            Console.WriteLine("Remaining Shipments");
            Console.WriteLine("=========================================");
            center.PrintAllShipments();
        }
    }
}
