using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.DataStructures
{
    class StatisticsCalculator
{
    static void Main()
    {
        List<double> responseTimes = new List<double>();
        string input;

        // Collect response times
        while (true)
        {
            Console.Write("Enter a number (or 'done' to finish): ");
            input = Console.ReadLine().Trim();

            if (input.ToLower() == "done")
                break;

            if (double.TryParse(input, out double value))
            {
                responseTimes.Add(value);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        // Ensure we have data before calculating statistics
        if (responseTimes.Count == 0)
        {
            Console.WriteLine("No numbers entered. Exiting.");
            return;
        }

        // Compute statistics
        double mean = Mean(responseTimes);
        double min = responseTimes.Min();
        double max = responseTimes.Max();
        double stdDev = StandardDeviation(responseTimes, mean);

        // Print results
        Console.WriteLine($"\nNumbers: {string.Join(", ", responseTimes)}");
        Console.WriteLine($"The average is {mean:F2}");
        Console.WriteLine($"The minimum is {min}");
        Console.WriteLine($"The maximum is {max}");
        Console.WriteLine($"The standard deviation is {stdDev:F2}");
    }

    // Calculate mean (average)
    static double Mean(List<double> numbers)
    {
        return numbers.Sum() / numbers.Count;
    }

    // Calculate standard deviation
    static double StandardDeviation(List<double> numbers, double mean)
    {
        double variance = numbers.Select(n => Math.Pow(n - mean, 2)).Sum() / numbers.Count;
        return Math.Sqrt(variance);
    }
}

}
