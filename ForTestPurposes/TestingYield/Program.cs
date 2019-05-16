using System;
using System.Collections.Generic;

namespace TestingYield
{
    public class Program
    {
        static void Main()
        {
            //
            // Compute two with the exponent of 30.
            //
            foreach (int value in ComputePower(2, 30))
            {
                Console.Write(value);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        public static IEnumerable<int> ComputePower(int number, int exponent)
        {
            int exponentNum = 0;
            int numberResult = 1;
            //
            // Continue loop until the exponent count is reached.
            //
            while (exponentNum < exponent)
            {
                //
                // Multiply the result.
                //
                numberResult *= number;
                exponentNum++;
                //
                //Return the result with yield.
                //
                yield return numberResult;
            }
        }
    }
}
