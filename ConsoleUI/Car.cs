using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{       /*
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods */
    public class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Drives Well");
        }
        public override void PrintDetails()
        {
            Console.WriteLine($"Trunk intact? {HasTrunk}");
        }
        public bool HasTrunk { get; set; }

    }
}              

