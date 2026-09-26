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
        }
    }
}
