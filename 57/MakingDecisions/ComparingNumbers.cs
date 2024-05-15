using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.MakingDecisions
{
    internal class ComparingNumbers
    {
        static void Comparing()
        {
            int largest, num1, num2, num3 = 0;

            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            num3 = int.Parse(Console.ReadLine());

            while (num1 == num2 || num2 == num3 || num3 == num1)
            {
                break;
            }

            if (num1 > num2 && num1 > num3)
            {
                largest = num1;
                Console.WriteLine("The largest number is: {0}",largest);
            }
            
            else if (num2 > num1 && num2 > num3)
            {
                largest = num2;
                Console.WriteLine("The largest number is: {0}", largest);
            }
            else
            {
                largest = num3;
                Console.WriteLine("The largest number is: {0}", largest);
            }

        }
    }
}
