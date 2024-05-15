using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Functions
{
    internal class AnagramChecker
    {
        static void ANA()
        {
            string anagram, name1, name2 = "";
            Console.WriteLine("Enter 2 strings and I'll tell you if they are anagrams:");
            Console.Write("Enter the first string: ");
            name1 = Console.ReadLine();
            Console.Write("Enter the first string: ");
            name2 = Console.ReadLine();

            isAnagram(name1, name2);
        }

        public static bool isAnagram(string a, string b)
        {
            Console.WriteLine();
            bool check = false;

            if (a.Length == b.Length)
            {
                if (a.Contains(b) || b.Contains(a))
                {
                    Console.WriteLine("\"{0}\" and \"{1}\" are anagrams.");
                    check = true;
                }
                else
                {
                    Console.WriteLine("\"{0}\" and \"{1}\" are not anagrams.");
                    check = false;
                }
            }
            else
            {
                Console.WriteLine("Your strings have unequal length.");
                check = false;
            }
            return check;
        }
    }
}
