using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.MakingDecisions
{
    internal class BMICalculator
    {
        static void BMI()
        {
            //Variables
            double bmi=0, weight, height = 0;

            //Prompt
            Console.Write("Enter your weight: ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Enter your height: ");
            height = double.Parse(Console.ReadLine());

            //Calculation
            bmi = (weight / (height * height)) * 703;

            //Decision
            if (bmi >= 18.5 && bmi <= 25)
            {
                //Display
                Console.WriteLine("Your BMI is {0}.", bmi);
                Console.WriteLine("You are within the ideal weight range.");
            }
            else if (bmi > 25)
            {
                //Display
                Console.WriteLine("Your BMI is {0}.", bmi);
                Console.WriteLine("You are overweight. You should see your doctor.");
            }
            else if (bmi > 30)
            {
                //Display
                Console.WriteLine("Your BMI is {0}.", bmi);
                Console.WriteLine("You are Obese. Take care of your health.");
            }
            else
            {
                //Display
                Console.WriteLine("Your BMI is {0}.", bmi);
                Console.WriteLine("You are Underweight. Make sure you have eat properly.");
            }


        }
    }
}
