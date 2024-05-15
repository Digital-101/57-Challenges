using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Calculations
{
    internal class CompoundInterest
    {
        static void Compound()
        {

            double P, y=0, t = 0;
            double A, r = 0;
            double exp = Math.Exp(y * t);
            Console.Write("What is the principal amount? ");
            P = double.Parse(Console.ReadLine());
            Console.Write("What is the rate? ");
            r = double.Parse(Console.ReadLine());
            Console.Write("What is the number of years? ");
            y = double.Parse(Console.ReadLine());
            Console.Write("What is the number of times the interest \nis compounded per year? ");
            for (int i = 1; i < y + 1; i++)
            {
                A = P * Math.Pow((1 + r / t), (t * i));
                Console.Write("Your Total for Year {0} " + "is {1}. \n", i, Math.Round(A, 2));
            }

            //double exp = Math.Exp(y * t);
            //A = P * (1 + ((r / 100) / y) * exp);
            //Console.WriteLine();
            //Console.WriteLine("{0} invested at {1}%, for {2} years \ncompounded " +
            //    "{3} times per year is ${4}.", P, r, y, t, A);

        }
    }
}
