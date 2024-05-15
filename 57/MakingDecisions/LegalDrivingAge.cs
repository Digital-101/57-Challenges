using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.MakingDecisions
{
    internal class LegalDrivingAge
    {
        static void Drive()
        {
            int age = 0;

            Console.Write("What is your age? ");
            age = int.Parse(Console.ReadLine());

            if (age >= 16)
            {
                Console.WriteLine("You are old enough to Legally Drive.");

            }
            else
            {
                Console.WriteLine("You are not old enough to legally Drive.");
            }
        }
    }
}
