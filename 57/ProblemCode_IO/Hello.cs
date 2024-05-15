using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.ProblemCode
{
    internal class Hello
    {
        static void Saying()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, "+name+", nice to meet you!");
        }
    }
}
