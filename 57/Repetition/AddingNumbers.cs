using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Repetition
{
    internal class AddingNumbers
    {
        static void Loop()
        {
            int total = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                total += num;
            }
            Console.WriteLine($"The total is {total}.");
            Console.Read();
        }
    }
}
