using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Calculations
{
    internal class SelfCheckout
    {
        static void Checkout()
        {
            double price, Total=0, Tax=0,SubTotal = 0;
            int quantity = 0;
            double Allprice = 0;

            for (int i = 1; i < 4; i++)
            {
                try
                {

                    Console.Write("Enter the price of item {0}:", i);
                    price = double.Parse(Console.ReadLine());

                    Console.Write("Enter the quantity of item {0}:", i);
                    quantity = int.Parse(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Enter numeric value only...");
                    break;
                }

                //Calculations
                price *= quantity;
                Allprice += price;

                SubTotal = Allprice;
                Tax = SubTotal * 0.055;
                Total = SubTotal + Tax;
            }

            Console.WriteLine("##################################################");
            Console.WriteLine("Subtotal: "+SubTotal.ToString("C"));
            Console.WriteLine("Txax: " + Tax.ToString("C"));
            Console.WriteLine("Total: " + Total.ToString("C"));
            Console.WriteLine("##################################################");
            Console.Read();

        }
    }
}
