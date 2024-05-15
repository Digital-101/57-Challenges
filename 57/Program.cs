using _57.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age = 0;
            double heartRate = 0;
            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter your resting heart rate: ");
            heartRate = double.Parse(Console.ReadLine());

            Console.WriteLine("Intesity\t| Rate");
            Console.WriteLine("--------------|---------");
            for (int i = 55; i < 96; i++)
            {
                double ins = i / 100;
                double targetHR = (((220 - age) - heartRate) * ins) + heartRate;
                Console.WriteLine($"{i}%\t{targetHR} | bpm");
            }


        }

    }
}
