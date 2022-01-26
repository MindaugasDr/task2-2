using System;
using System.Collections.Generic;
using System.Linq;
using Task2.Calculation;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConveyorSystem conveyorSystem = new ConveyorSystem();
            conveyorSystem.startProgram();

            Console.ReadKey();
        }

    }
}
