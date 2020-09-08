using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("This bike is in drive");
        }
        public bool HasSideCar { get; set; } = false;
        public override void DriveVirtual()
        {
            Console.WriteLine("This bike is in V-dirve");
        }

    }
}
