using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.ProblemCode
{
    internal class SimpleMath
    {
        static void SimpleMathematics()
        {
            int num1, num2 = 0;

            Console.Write("What is the first number? ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("What is the second number? ");
            num2 = int.Parse(Console.ReadLine());

            int sum, prod, coec, diff = 0;
            sum = num1 + num2;
            prod = num1 * num2;
            coec = num1 / num2;
            diff = num1 - num2;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, diff);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, prod);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, coec);

        }
    }
}
