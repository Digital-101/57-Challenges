using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Repetition
{
    internal class MultiplicationTable
    {
        static void Multiply()
        {
            int num = 0, ans = 0;
            for (int i = 0; i < 13; i++)
            {
                num *= i;
                ans = num;
                Console.Write("{0} X {1} = {2}\n", num, i, ans);
                Console.WriteLine();
                for (int j = 0; j < 13; j++)
                {
                    num = 2;
                    ans = num * j;
                    Console.Write("{0} X {1} = {2}\n", num, j, ans);
                    Console.WriteLine();
                }
            }
        }
    }
}
