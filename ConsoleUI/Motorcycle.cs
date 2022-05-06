using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle

    {
        public Motorcycle()
        {
        }

        public bool HasChainDrive { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("This Motorcyle is in gear");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that is a virtually in gear");
        }




    }
}
