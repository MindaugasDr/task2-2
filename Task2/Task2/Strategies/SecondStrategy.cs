using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class SecondStrategy : AbstractStrategy
    {

        public SecondStrategy() {
            destinations = new Dictionary<int, int>();
            currentDestination = 1;
            currentConsecutiveDelivers = 0;
        }

        protected override void assignDestination(int numberOfDestinations, int numberOfConsecutiveLoads)
        {
            if (currentConsecutiveDelivers == numberOfConsecutiveLoads)  //Checks if needs to change destination
            {
                Random rand = new Random();
                currentDestination = rand.Next(1, numberOfDestinations+1);
                currentConsecutiveDelivers = 1;
            }
            else  //Didn't need to change destination, load sent to the same destination as previous one.
            {
                currentConsecutiveDelivers++;
            }
        }
    }
}
