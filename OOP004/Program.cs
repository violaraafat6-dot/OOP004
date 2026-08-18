using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Numerics;

namespace OOP004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1

            //            Q1
            //(A)Abstraction is hiding the complex implementation details and showing only the important information or functionality to the user

            //(b)Because it helps us focus on what an object does instead of how it does it, which makes
            //the code easier to understand and maintain

            #endregion

            #region question2

            //            Q2
            //(a)An abstract class can contain fields, constructors, properties, methods, and abstract members.
            //An interface mainly defines a contract that classes must implemen

            //(b)I would choose an interface when different classes need to follow the same contract, even
            //if they are not related through inheritance

            //            (c)No, a class cannot inherit from multiple classes
            //Yes, a class can implement multiple interfaces

            #endregion

            #region practical

//            DeliveryCenter center = new DeliveryCenter();

//            DeliveryAddress address =
//                new DeliveryAddress("Cairo", "Main Street", 10);

//            StandardShipment standardShipment =
//                new StandardShipment(
//                    "SH001",
//                    "Laptop",
//                    3,
//                    80,
//                    address);

//            ExpressShipment expressShipment =
//                new ExpressShipment(
//                    "SH002",
//                    "Mobile Phone",
//                    2,
//                    60,
//                    address,
//                    30);

//            InternationalShipment internationalShipment =
//                new InternationalShipment(
//                    "SH003",
//                    "Television",
//                    8,
//                    120,
//                    address,
//                    "Germany",
//                    100);

//            center.AddShipment(standardShipment);
//            center.AddShipment(expressShipment);
//            center.AddShipment(internationalShipment);

//            Console.WriteLine("==========================================");
//            Console.WriteLine("Delivery Center");
//            Console.WriteLine("==========================================");

//            center.PrintAllShipments();

//            Console.WriteLine("==========================================");
//            Console.WriteLine("Tracking Status");
//            Console.WriteLine("==========================================");

//            center.PrintTrackingStatuses();

//            Console.WriteLine("==========================================");
//            Console.WriteLine("Insurance");
//            Console.WriteLine("==========================================");

//            Console.WriteLine(
//                $"Standard Shipment Insurance : {standardShipment.CalculateInsurance():0.00} EGP");

//            Console.WriteLine(
//                $"Express Shipment Insurance : {expressShipment.CalculateInsurance():0.00} EGP");

//            Console.WriteLine(
//                $"International Shipment Insurance : {internationalShipment.CalculateInsurance():0.00} EGP");

//            Console.WriteLine("==========================================");
//            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
//            Console.WriteLine("==========================================");

//            ITrackable[] trackableShipments =
//            {
//                standardShipment,
//                expressShipment,
//                internationalShipment
//            };

//            foreach (ITrackable shipment in trackableShipments)
//            {
//                DeliveryReport.PrintShipment(shipment);
//            }

//            IInsurable[] insurableShipments =
//            {
//                standardShipment,
//                expressShipment,
//                internationalShipment
//            };

//            foreach (IInsurable shipment in insurableShipments)
//            {
//                DeliveryReport.PrintInsurance(shipment);
//            }
//        }
//    }
//}



            #endregion

      