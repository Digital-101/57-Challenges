using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _57.ProblemCode
{
    internal class MadLib
    {
         
        static void Simple()
        {
            string noun, verb, adjective, adverb = "";

            Console.Write("Enter a noun: ");
            noun = Console.ReadLine();

            Console.Write("Enter a verb: ");
            verb = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            adjective = Console.ReadLine();

            Console.Write("Enter an adverb: ");
            adverb = Console.ReadLine();

            Console.WriteLine("Do you {0} your {1} {2} {3}",verb,adjective,noun,adverb);
        }
    }
}
