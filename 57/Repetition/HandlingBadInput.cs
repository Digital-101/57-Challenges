using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Repetition
{
    internal class HandlingBadInput
    {
        static void BadInput()
        {
            double years, rate = 0;
            Console.Write("What is the rate of return? ");
            rate = double.Parse(Console.ReadLine());

            if (rate == 0)
            {
                Console.WriteLine("Sorry. That's not a valid input.");
            }
            while (!double.TryParse(Console.ReadLine(), out rate))
            {
                Console.Write("What is the rate of return? ");
                rate = double.Parse(Console.ReadLine());
                Console.WriteLine("Sorry. That's not a valid input.");
            }

            years = 72 / rate;

            Console.WriteLine($"It will take {years} years to double your initial investment.");
        }
    }
}
