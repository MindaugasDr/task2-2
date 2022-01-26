using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ConveyorSystem
    {
        public void startProgram()
        {
            ConveyorSystem system = new ConveyorSystem();
            InputMethods inputMethods = new InputMethods();
            Console.WriteLine("Enter the number of available destinations:");
            int numberOfDestinations = inputMethods.insertData(InputTypes.Number);
            Console.WriteLine("Number of destinations - " + numberOfDestinations);
            Console.WriteLine();

            Console.WriteLine("Enter the number of destination selection strategy:");
            Console.WriteLine("1 - Round robin (1,2,3,..n, 1,2,3,…,n , … )");
            Console.WriteLine("2 - Random (select a destination randomly with the same probability weight for destination)");
            int selectedStrategy = inputMethods.insertData(InputTypes.Strategy);
            Console.WriteLine("Selected strategy - " + selectedStrategy);
            Console.WriteLine();

            Console.WriteLine("Enter the number of consecutive loads:");
            int numberOfConsecutiveLoads = inputMethods.insertData(InputTypes.Number);
            Console.WriteLine("Number of consecutive loads - " + numberOfConsecutiveLoads);
            Console.WriteLine();

            Console.WriteLine("Enter a percentage of failure for load to be diverted into its destination:");
            int probabilityOfFailure = inputMethods.insertData(InputTypes.Percents);
            Console.WriteLine("Number of consecutive loads - " + probabilityOfFailure + "%");
            Console.WriteLine();

            Console.WriteLine("Enter the number of loads:");
            int numberOfLoads = inputMethods.insertData(InputTypes.Number);
            Console.WriteLine("Number of loads - " + numberOfLoads);
            Console.WriteLine();


            AbstractStrategy activeStrategy;
            if (selectedStrategy == 1)
                activeStrategy = new FirstStrategy();
            else activeStrategy = new SecondStrategy();

            activeStrategy.startConveyer(numberOfDestinations, numberOfConsecutiveLoads, probabilityOfFailure, numberOfLoads);
            activeStrategy.printDestinationsInfo(numberOfLoads);
        }


    }
}
