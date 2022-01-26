using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class InputMethods
    {

        public bool isCorrectInput(string type, int input)
        {
            if (type.Equals(InputTypes.Number))
            {
                return (input > 0);
            }
            if (type.Equals(InputTypes.Percents))
            {
                return (input >= 0 && input <= 100);
            }
            if (type.Equals(InputTypes.Strategy))
            {
                return (input > 0 && input <= 2);
            }
            return false;
        }


        public int insertData(string type)
        {
            bool valid = false;
            int input = 0;
            while (!valid)
            {
                valid = Int32.TryParse(Console.ReadLine(), out input) && isCorrectInput(type, input);
                if (!valid)
                {
                    Console.WriteLine("The input is incorrect!");
                }
            }
            return input;
        }



    }
}
