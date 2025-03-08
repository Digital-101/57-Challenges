using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string inputFile = "names.txt";
        string outputFile = "sorted_names.txt";

        // Check if the input file exists
        if (!File.Exists(inputFile))
        {
            Console.WriteLine($"Error: The file '{inputFile}' does not exist. Please create it and add names.");
            return;
        }

        try
        {
            // Read names from the file
            List<string> names = File.ReadAllLines(inputFile).ToList();

            // Sort the names alphabetically
            names.Sort();

            // Write sorted names to output file
            File.WriteAllLines(outputFile, names);

            // Display results
            Console.WriteLine($"Total of {names.Count} names");
            Console.WriteLine("-----------------");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"\nSorted names have been saved to '{outputFile}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
