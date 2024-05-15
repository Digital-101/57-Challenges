using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Functions
{
    internal class MonthsToPayOFCC
    {
        static void PAyOff()
        {
            double balance = 0, APR = 0, p=0,i=0;
            Console.Write("What is your balance? ");
            balance = double.Parse(Console.ReadLine()); 
            Console.Write("What is the APR on the card (as a percent)? ");
            APR = double.Parse(Console.ReadLine());

            Console.Write("What is the monthly payment you can make? ");
            p = double.Parse(Console.ReadLine());

            MonthsToPayOFCC obj = new MonthsToPayOFCC();
            obj.NumMonths(balance,APR,p);

        }

        public double NumMonths(double bal, double apr, double p)
        {
            double i = Math.Round((bal * apr) / 365);
            double Totmonths = -(1 / 30) * (Math.Log(1 + (bal / p) * (1 - (1 + i) * Math.Pow(30, 30)))) / Math.Log(1 + i);
            Console.WriteLine("It will take you {0} months to pay off this card.", Totmonths);
            return Totmonths;
        }
    }
}
