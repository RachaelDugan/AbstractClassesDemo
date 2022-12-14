using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles= new List<Vehicle>();

            /*
            * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
            * 
            * Set the properties with object initializer syntax
            */

            var car1 = new Car() { Year = "2006", Make = "Ford", Model = "Fiesta", HasTrunk = true, };
            vehicles.Add(car1);
            Vehicle vehic1 = new Car() { Year = "2011", Make = "BMW", Model = "Series 335i", HasTrunk = true};
            vehicles.Add(vehic1);
           
            var moto1 = new Motorcycle()
            {
                Year = "1994",
                Make = "Honda",
                Model = "cb1000",
                HasSideCart = true
            };
            vehicles.Add(moto1);
            Vehicle moto2 = new Motorcycle()
            {
                Year = "2022",
                Make = "Kawasaki",
                Model = "KLR 650",
                HasSideCart = false
            };
            vehicles.Add(moto2);

            /*
            * Add the 4 vehicles to the list
            * Using a foreach loop iterate over each of the properties
            */
            // Call each of the drive methods for one car and one motorcycle

            Console.WriteLine("THESE CARS ARE UP FOR AUCTION!: ");
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine();
                Console.WriteLine($" Vehicle details: {vehicle.Year} {vehicle.Make} {vehicle.Model}");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                vehicle.PrintDetails();
                Console.WriteLine();
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                
            }
            




           

           

            

            #endregion
           
        }
    }
}
