using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.ProblemCode
{
    internal class CountingCharacters
    {
        static void Counting()
        {
            string Input = "";
            int chars = 0;
            Console.Write("What is the input string? ");
            Input = Console.ReadLine();

            for (int i = 0; i < Input.Length; i++)
            {
                chars++;
            }
            Console.WriteLine("{0} has {1} characters.",Input, chars);
            Console.WriteLine();
        }
    }
}
