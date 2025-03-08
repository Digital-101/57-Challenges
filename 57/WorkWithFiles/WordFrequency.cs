using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Prompt for the file name
        Console.Write("Enter the file name: ");
        string fileName = Console.ReadLine();

        // Check if file exists
        if (!File.Exists(fileName))
        {
            Console.WriteLine("Error: File not found.");
            return;
        }

        try
        {
            // Read the file content
            string content = File.ReadAllText(fileName).ToLower();

            // Split words using regex (removes punctuation)
            string[] words = Regex.Split(content, @"\W+")
                                  .Where(w => !string.IsNullOrEmpty(w))
                                  .ToArray();

            // Count word occurrences
            var wordCounts = words.GroupBy(w => w)
                                  .ToDictionary(g => g.Key, g => g.Count());

            // Sort words by frequency (descending)
            var sortedWordCounts = wordCounts.OrderByDescending(kvp => kvp.Value);

            // Print the histogram
            Console.WriteLine("\nWord Frequency Histogram:");
            Console.WriteLine("============================");
            foreach (var pair in sortedWordCounts)
            {
                Console.WriteLine($"{pair.Key}: {new string('*', pair.Value)}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
