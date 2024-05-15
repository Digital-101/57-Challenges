using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.MakingDecisions
{
    internal class BloodAlcoholDetector
    {
        static void Blood()
        {
            double BAC= 0, weight, hours, drinks, volume = 0;
            string gender = "";

            Console.Write("Enter your weight: ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Enter your gender: ");
            gender = Console.ReadLine();    
            Console.Write("Enter number of drinks: ");
            drinks = double.Parse(Console.ReadLine());

            Console.Write("Enter amount of alcohol consumed: ");
            volume = double.Parse(Console.ReadLine());

            Console.Write("Enter amount of time since last drink: ");
            hours = double.Parse(Console.ReadLine());

            if (gender == "MALE" || gender == "male")
            {
                double r = volume * 0.73;
                BAC = (drinks * 5.14 / (weight * r) - 0.015 * hours);
            }
            else if (gender == "FEMALE" || gender == "female")
            {
                double r = volume * 0.66;
                BAC = (drinks * 5.14 / (weight * r) - 0.015 * hours);
            }
            //BAC = 

            if (BAC == 0.08)
            {
                Console.WriteLine("Your BAC is " + BAC);
                Console.WriteLine("It is no legal for you to drive.");
            }
            else
            {
                Console.WriteLine("Your BAC is " + BAC);
                Console.WriteLine("It is legal for you to drive.");
            }
        }
    }
}
