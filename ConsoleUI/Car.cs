using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in dirve");
        }
        public bool HasTrunk { get; set; } = true;
    }
}
