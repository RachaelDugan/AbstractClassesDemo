using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /* 
* Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
* Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
* Provide the implementations for the abstract methods
* Only in the Motorcycle class will you override the virtual drive method
*/
    internal class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Drives Well");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Moto Virtual Default");
        }
        public override void PrintDetails()
        {
            Console.WriteLine($"Comes with a sidecar? {HasSideCart}");

        }
        public bool HasSideCart { get; set; }    
        
    }
}
