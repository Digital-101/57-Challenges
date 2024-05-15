using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Calculations
{
    internal class SimpleInterest
    {
        static void Simple()
        {
            int p, t = 0;
            double A, intr = 0;

            Console.Write("Enter the principal: ");
            p = int.Parse(Console.ReadLine());
            Console.Write("Enter the rate of interest: ");
            intr = double.Parse(Console.ReadLine());
            Console.Write("Enter the number of years: ");
            t = int.Parse(Console.ReadLine());
            A = p*(1 + ((intr / 100) * t));
            Console.WriteLine();
            Console.WriteLine("After {0} years at {1}%, the investment will be worth ${2}.", t,intr,A);
        
        }
    }
}
