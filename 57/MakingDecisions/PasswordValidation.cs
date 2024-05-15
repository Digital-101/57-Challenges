using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.MakingDecisions
{
    internal class PasswordValidation
    {
        static void Pass()
        {
            string password = "abc$123";
            string inputPass = "";
            Console.Write("What is the password? ");
            inputPass = Console.ReadLine();

            if (inputPass!= password)
            {
                Console.WriteLine("I don't know you.");
            }
            else
            {
                Console.WriteLine("Welcome!");
            }
        }
    }
}
