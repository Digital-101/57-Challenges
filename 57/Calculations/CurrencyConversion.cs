using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Calculations
{
    internal class CurrencyConversion
    {
        static void Conv()
        {
            const double EUREXCHANGE = 137.51;
            const double USDEXCHANGE = 111.38;
            double Euroes = 0;
            double frmEX = 0, toEX = 0;

            //calculate
            //frmEX = EUREXCHANGE;
            toEX = USDEXCHANGE;


            Console.Write("How many euros are you exchanging? ");
            Euroes = double.Parse(Console.ReadLine());
            Console.Write("What is the exhange rate? ");
            frmEX = double.Parse(Console.ReadLine());


            double EUR = Euroes * EUREXCHANGE;
            double USD = EUR / USDEXCHANGE;

            //
            Console.WriteLine("{0} euros at an exchange rate of {1} is \n{2} U.S. dollars.", Euroes, frmEX, toEX);
            Console.WriteLine();
            Console.WriteLine("You have {0} EUR", Euroes);
            Console.WriteLine("That is {0} USD", USD);
            Console.Read();

        }
    }
}
