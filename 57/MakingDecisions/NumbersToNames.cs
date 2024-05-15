using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.MakingDecisions
{
    internal class NumbersToNames
    {
        static void NumNames()
        {
            string month = "";
            int monthNumber = 0;
            Console.Write("Please enter the number of the month: ");
            monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 01:
                    month = "January";
                    break;
                case 02:
                    month = "February";
                    break;
                case 03:
                    month = "March";
                    break;
                case 04:
                    month = "April";
                    break;
                case 05:
                    month = "May";
                    break;
                case 06:
                    month = "June";
                    break;
                case 07:
                    month = "July";
                    break;
                case 08:
                    month = "August";
                    break;
                case 09:
                    month = "September";
                    break;
                case 10:
                    month = "October";
                    break;
                case 11:
                    month = "November";
                    break;
                case 12:
                    month = "December";
                    break;
                default:
                    break;
            }
            Console.WriteLine("The name of the month is {0}.",month);
        }
    }
}
