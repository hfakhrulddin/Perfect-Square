using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number for testing");
                long TestValue = int.Parse(Console.ReadLine());
                bool result = IsSquare(TestValue);
                Console.WriteLine(result);
            }
        }

        /// <summary>
        /// //////////////////function
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
            public static bool IsSquare(long target)
        {
            // handle 0 and 1
            if (target <= 1)
                return true;

            long currentSquare = 4;
            long currentNumber = 2;

            // loop through till the target is more than
            // the square of the current number
            while (currentSquare <= target)
            {
                // if we have a match, return true
                if (currentSquare == target)
                    return true;
                // increment current number
                currentNumber++;
                // find the next square
                currentSquare = currentNumber * currentNumber;
            }
            // no matching number could be squared
            return false;
        }
    }
}