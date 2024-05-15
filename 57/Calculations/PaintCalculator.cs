using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Calculations
{
    internal class PaintCalculator
    {
        static void PaintCalc()
        {
            int length, width, sqft, gallons  = 0;
            const int SQUAREFEET = 350;

            Console.Write("Enter length: ");
            length = int.Parse(Console.ReadLine());
            Console.Write("Enter breadth: ");
            width = int.Parse(Console.ReadLine());

            sqft = length * width;

            if (sqft <= SQUAREFEET)
            {
                gallons = 1;
            }
            else
            {
                gallons++;
            }

            Console.WriteLine("You will need to purchase {0} gallons of " +
                "\npaint to cover {1} square feet.",gallons,sqft);

        }
    }
}
