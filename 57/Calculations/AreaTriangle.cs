using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Calculations
{
    internal class AreaTriangle
    {
        static void Area()
        {
            const double formval = 0.09290304;
            double len, widt, sqFT, sqMT = 0;
            double area = 0;

            Console.Write("What is the length of the room in feet? ");
            len = double.Parse(Console.ReadLine());
            
            Console.Write("What is the width of the room in feet? ");
            widt = double.Parse(Console.ReadLine());

            sqFT = len * widt;
            sqMT = sqFT * formval;

            Console.WriteLine("You entered dimensions of {0} feet by {1} feet.",len,widt);
            Console.WriteLine("The area is: \n{0} square feet\n{1} square meters",sqFT,sqMT);
        }
    }
}
