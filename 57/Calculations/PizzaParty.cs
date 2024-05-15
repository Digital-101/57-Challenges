using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Calculations
{
    internal class PizzaParty
    {
        static void Slices()
        {
            //variables
            int people, pizzas, slices, leftover = 0;

            //Prompt
            Console.Write("How many people? ");
            people = int.Parse(Console.ReadLine());
            Console.Write("How many pizzas do you have? ");
            pizzas = int.Parse(Console.ReadLine());

            Console.WriteLine();

            //calculation
            slices = people * pizzas;
            int each_slice = slices / people;
            //leftover = slices % 2;

            //Results
            Console.Write("{0} people with {1} pizzas.",people, pizzas);
            Console.Write("Each person gets {0} pieces of pizza.",each_slice);
            Console.Write("There are {0} leftover pieces.",leftover);

            //
            ////variables
            //int people, pizzas, slices, pizzSlic = 0;

            ////Prompt
            //Console.Write("How many people? ");
            //people = int.Parse(Console.ReadLine());
            //Console.Write("How many pizzas slices for each person? ");
            //slices = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            ////calculation
            //pizzSlic = people * slices;
            //pizzas = pizzSlic / people;
            ////leftover = slices % 2;

            ////Results
            //Console.Write("{0} people with {1} slices.", people, slices);
            //Console.Write("\nYou need to purchase {0} pizzas.", pizzas);
            ////Console.Write("\nThere are {0} leftover pieces.", leftover);
            //Console.WriteLine();
            //Console.ReadLine();

        }
    }
}
