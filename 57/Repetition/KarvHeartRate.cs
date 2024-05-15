using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Repetition
{
    internal class KarvHeartRate
    {
        static void Heart()
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
                double targetHR = (((220 - age) - heartRate) * i) + heartRate;
                Console.WriteLine($"{i}%\t{targetHR} | bpm");
            }

        }
    }
}
