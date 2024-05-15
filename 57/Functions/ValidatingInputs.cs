using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Functions
{
    internal class ValidatingInputs
    {
        static void ValidInput()
        {
            Console.Write("Enter the first name: ");
            string fname = Console.ReadLine();

            Console.Write("Enter the last name: ");
            string lname = Console.ReadLine();

            Console.Write("Enter the ZIP code: ");
            string zip = Console.ReadLine();

            Console.Write("Enter an employee ID: ");
            string empId = Console.ReadLine();

            ValidatingInputs obj = new ValidatingInputs();

        }

        public string ValidateINP(string fname, string lname, string zip, string empId)
        {
            string output = "";
            if (String.IsNullOrEmpty(fname) || fname.Length < 2)
            {

            }

            return output;
        }
    }
}
