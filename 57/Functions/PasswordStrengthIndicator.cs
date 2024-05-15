using _57.MakingDecisions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _57.Functions
{
    internal class PasswordStrengthIndicator
    {
        static void PasswordStrength()
        {
            string pass = "";

            Console.Write("Create your password: ");
            pass = Console.ReadLine();

            PasswordStrengthIndicator obj = new PasswordStrengthIndicator();

            obj.passwordValidator(pass);
        }

        public string passwordValidator(string pass)
        {
            //string pass = "";
            string indicator = "";
            string Vweak = "0123456789";
            string weak = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string strong = "";
            string Vstrong = "!@#$%^&*()_+=-/.,;[]";

            //pass = Console.ReadLine();
            Regex regex = new Regex(pass);

            if (pass.Contains(Vweak))
            {
                Console.WriteLine("The password '{0}' is a very weak password.",pass);
                indicator = "Very Week";
            }
            else if (pass.Contains(weak))
            {
                Console.WriteLine("The password '{0}' is a weak password.",pass);
                indicator = "Weak";

            }
            else if (pass.Contains(Vweak) && pass.Contains(weak))
            {
                Console.WriteLine("The password '{0}' is a strong password.", pass);
                indicator = "Strong";

            }
            else//(pass.Contains(Vweak) && pass.Contains(weak) && pass.Contains(Vstrong))
            {
                Console.WriteLine("The password '{0}' is a very strong password.", pass);
                indicator = "Very Strong";
            }

            return indicator;
        }
    }
}
