using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    abstract class AbstractStrategy
    {
        protected Dictionary<int, int> destinations { get; set; }
        protected int currentDestination { get; set; }
        protected int currentConsecutiveDelivers { get; set; }

        protected abstract void assignDestination(int numberOfDestinations, int numberOfConsecutiveLoads);

        private bool isDerived(int probabilityOfFailure)
        {
            Random rand = new Random();
            return (rand.Next(1, 100) > probabilityOfFailure);
        }

        private void addPackageToDestination(Dictionary<int, int> destinations, int destination)
        {
            int reachedPackages;
            if (destinations.TryGetValue(destination, out reachedPackages))    //Checks if any packages already reached that destination
            {
                destinations[destination] = reachedPackages + 1;
            }
            else
            {
                destinations.Add(destination, 1);
            }
        }

        public void startConveyer(int numberOfDestinations, int numberOfConsecutiveLoads, int percentageOfFailure, int numberOfLoads)
        {
            for (int i = 0; i < numberOfLoads; i++)
            {
                assignDestination(numberOfDestinations, numberOfConsecutiveLoads);

                if (!isDerived(percentageOfFailure))
                {
                    addPackageToDestination(destinations, 0);
                }
                else
                {
                    addPackageToDestination(destinations, currentDestination);
                }
            }
        }

        public void printDestinationsInfo(int numberOfLoads) 
        {

            Console.WriteLine("Results: ");
            Console.WriteLine("Destination - How many packages reached the destination");
            foreach (var item in destinations.OrderBy(item => item.Key))
            {
                int percentagePart = (int)Math.Round((double)(100 * item.Value) / numberOfLoads);
                Console.WriteLine(item.Key.ToString() + " - " + percentagePart.ToString() + "% " + item.Value);
            }
        }

    }
}
