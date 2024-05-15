using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.MakingDecisions
{
    internal class MultiStateTax
    {
        static void Multi()
        {
            double Amt, tax = 0.055, SubTotal = 0, Total = 0;
            string state, county = "";
            Console.Write("What is the order amount? ");
            Amt = double.Parse(Console.ReadLine());

            Console.Write("What is the state? ");
            state = Console.ReadLine();

            SubTotal = Amt;
            Total = Amt;

            if (state == "Wisconsin")
            {
                Console.Write("Enter county of residence. ");
                county = Console.ReadLine();

                if (county == "For Eau Claire")
                {
                    tax = 0.005; Total = SubTotal + (Amt * tax);
                    //Console.WriteLine("The subtotal is " + SubTotal.ToString("C"));
                    tax = tax * 10;
                    Console.WriteLine("The tax is " + tax.ToString("C"));
                    Console.WriteLine("The Total is " + Total.ToString("C"));
                }
                else if (county == "Dunn")
                {
                    tax = 0.004;
                    Total = SubTotal + (Amt * tax);
                    //Console.WriteLine("The subtotal is " + SubTotal.ToString("C"));
                    tax = tax * 10;
                    Console.WriteLine("The tax is " + tax.ToString("C"));
                    Console.WriteLine("The Total is " + Total.ToString("C"));
                }
              
            }
            else if (state == "Illinois")
            {
                tax = 0.08;
                Total = SubTotal + (Amt * tax);
                //Console.WriteLine("The subtotal is " + SubTotal.ToString("C"));
                tax = tax * 10;
                Console.WriteLine("The tax is " + tax.ToString("C"));
                Console.WriteLine("The Total is " + Total.ToString("C"));
            }
            else
            {
                Console.WriteLine("The total is " + Total.ToString("C"));
            }
        }
    }
}
