using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.DataStructures
{
    using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Prompt for input
        Console.Write("Enter a list of numbers, separated by spaces: ");
        string input = Console.ReadLine();

        // Convert input string to array of integers
        string[] inputArray = input.Split(' ');
        List<int> numbers = new List<int>();

        // Parse the input string into integers
        foreach (string number in inputArray)
        {
            if (int.TryParse(number, out int num))
            {
                numbers.Add(num);
            }
        }

        // Call function to filter even numbers
        List<int> evenNumbers = FilterEvenNumbers(numbers);

        // Output the result
        Console.WriteLine("The even numbers are: " + string.Join(" ", evenNumbers));
    }

    // Function to filter even numbers from the list
    static List<int> FilterEvenNumbers(List<int> numbers)
    {
        List<int> evenNumbers = new List<int>();

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }

        return evenNumbers;
    }
}

}
