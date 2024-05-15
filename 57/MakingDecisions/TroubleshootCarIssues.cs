using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.MakingDecisions
{
    internal class TroubleshootCarIssues
    {
        static void Trouble()
        {
            string Que, Ans = "";



            Console.Write("Is the car silent when you turn the key? ");
            Ans = Console.ReadLine();
            if (Ans == "YES" || Ans == "yes" || Ans == "y")
            {
                Console.Write("Are the battery terminals corroded? ");
                Ans = Console.ReadLine();

                if (Ans == "YES" || Ans == "yes" || Ans == "y")
                {
                    Console.WriteLine("Clean terminals and try starting again.");
                    Console.WriteLine("Replace cables and try again.");
                }
                else if (Ans == "NO" || Ans == "no" || Ans == "n")
                {
                    Console.WriteLine("Replace cables and try again.");
                    Console.WriteLine("Clean terminals and try starting again.");
                }
            }
            else if (Ans == "No" || Ans == "no" || Ans == "n")
            {
                Console.Write("Does the car make a clicking noise? ");
                Ans = Console.ReadLine();

                if (Ans == "YES" || Ans == "yes" || Ans == "y")
                {
                    Console.WriteLine("Replace the battery.");
                }
                else if (Ans == "NO" || Ans == "no" || Ans == "n")
                {
                    Console.Write("Does the car crank up but fail to start? ");
                    Ans = Console.ReadLine();
                    if (Ans == "YES" || Ans == "yes" || Ans == "y")
                    {
                        Console.WriteLine("Check spark plug connections.");
                    }
                    else if (Ans == "NO" || Ans == "no" || Ans == "n")
                    {
                        Console.Write("Does the car engine start and then die? ");
                        Ans = Console.ReadLine();
                        if (Ans == "YES" || Ans == "yes" || Ans == "y")
                        {
                            Console.Write("Does your car have fuel injection? ");
                            Ans = Console.ReadLine();
                            if (Ans == "YES" || Ans == "yes" || Ans == "y")
                            {
                                Console.WriteLine("Get it in for service.");
                            }
                            else if (Ans == "NO" || Ans == "no" || Ans == "n")
                            {
                                Console.WriteLine("Check to ensure the choke is opening and closing.");
                            }
                        }
                    }
                }
            }

        }
    }
}
