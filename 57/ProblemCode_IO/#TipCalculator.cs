using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.ProblemCode
{
    internal class TipCalculator
    {
        static void Fun()
        {
            double amount, rate = 0;
            double tip, total = 0;

            try
            {
                Console.WriteLine("Inputs:");
                Console.Write("\tBill Amount: ");
                amount = double.Parse(Console.ReadLine());
                Console.Write("\tTip Rate: ");
                rate = double.Parse(Console.ReadLine());
                tip = amount * (rate / 100);
                total = amount + tip;
                Console.WriteLine("Expected Result:");
                Console.Write("\tTip: " + tip.ToString("C"));
                Console.Write("\n\tTotal: " + total.ToString("C"));
                Console.WriteLine();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                //e.Message = "Expected Result";
                Console.WriteLine("Expected Result: Please enter a valid number for the bill amount.");
            }

        }
    }
}

