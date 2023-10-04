using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new List<int>();

            //-----START HERE------------------------------------------

            int num = 0;

            do
            {
                num++;
                numbers.Add(num);
            }
            while (num < 100);


            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }
            

            Console.WriteLine("Increase:");
          



            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            for (int i = 199; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);


             //------------End of exercise
            }
        }
    }
}
