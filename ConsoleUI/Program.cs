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
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            var tesla = new Car() { HasTrunk = true, Make = "Tesla", Model = "Model Y", Year = 2019 };
            var harley = new Motorcycle() { HasSideCar = false, Make = "Harley", Model = "Chopper", Year = 2005 };
            Vehicle sedan = new Car() { HasTrunk = true, Make = "Ford", Model = "Fusion", Year = 2010 };
            Vehicle compact = new Car() { Make = "Mini Cooper", Model = "Clubman", Year = 2020 };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(tesla);
            vehicles.Add(harley);
            vehicles.Add(sedan);
            vehicles.Add(compact);

            foreach(var veh in vehicles)
            {
                Console.WriteLine($"Make:{veh.Make}, Model:{veh.Model} Year:{veh.Year}");
                veh.DriveAbstract();
                veh.DriveVirtual();
                Console.WriteLine("----------------");
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
