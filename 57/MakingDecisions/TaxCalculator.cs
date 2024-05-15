using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.MakingDecisions
{
    internal class TaxCalculator
    {
        static void Tax()
        {
            double Amt, tax = 0.055, SubTotal = 0, Total = 0;
            string state = "";
            Console.Write("What is the order amount? ");
            Amt = double.Parse(Console.ReadLine());

            Console.Write("What is the state? ");
            state = Console.ReadLine();

            SubTotal = Amt;
            Total = Amt;

            if (state == "WI")
            {
                Total = SubTotal + (Amt * tax);
                Console.WriteLine("The subtotal is " + SubTotal.ToString("C"));
                tax = tax * 10;
                Console.WriteLine("The tax is " + tax.ToString("C"));
                Console.WriteLine("The subtotal is " + Total.ToString("C"));
            }
            else
            {
                Console.WriteLine("The total is " + Total.ToString("C"));
            }
        }
    }
}
