using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.ProblemCode
{
    internal class RetirementCalculator
    {

        static void Retire()
        {
            int rtYear, differ, retire, age = 0;
            Console.Write("What is your current age? ");
            age = int.Parse(Console.ReadLine());

            Console.Write("At what age would you like to retire? ");
            retire = int.Parse(Console.ReadLine());

            differ = retire - age;
            int thisyear = DateTime.Now.Year;
            rtYear = thisyear + differ;

            Console.WriteLine("You have {0} years left until you can retire.",differ);
            Console.WriteLine("It's {0}, so you can retire in {1}.",thisyear,rtYear);
        }
    }
}
