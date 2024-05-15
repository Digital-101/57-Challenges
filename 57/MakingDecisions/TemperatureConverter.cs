using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.MakingDecisions
{
    internal class TemperatureConverter
    {
        static void Temperature()
        {
            string choice = "";
            double temp, formula = 0;

            Console.WriteLine("Press C to convert from Fahrenheit to Celsius.");
            Console.WriteLine("Press F to convert from Celsius to Fahrenheit.");
            Console.Write("Your Choice: ");
            choice = Console.ReadLine();
            if (choice == "C" || choice == "c")
            {
                Console.Write("Please enter the temperature in Fahrenheit: ");
                temp = double.Parse(Console.ReadLine());
                formula = (temp - 32) * (5 / 9);
                Console.WriteLine("The temperature in Celsius is " + formula);
            }
            else if (choice == "F" || choice == "f")
            {
                Console.Write("Please enter the temperature in Celsius: ");
                temp = double.Parse(Console.ReadLine());
                formula = (temp * (9 / 5)) + 32;
                Console.WriteLine("The temperature in Celsius is " + formula);
            }
        }
    }
}
