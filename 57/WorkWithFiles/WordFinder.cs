using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Prompt for input file
        Console.Write("Enter the name of the input file: ");
        string inputFile = Console.ReadLine();

        // Check if file exists
        if (!File.Exists(inputFile))
        {
            Console.WriteLine("Error: File not found.");
            return;
        }

        // Prompt for output file
        Console.Write("Enter the name of the output file: ");
        string outputFile = Console.ReadLine();

        try
        {
            // Read the input file
            string content = File.ReadAllText(inputFile);

            // Replace occurrences of "utilize" with "use"
            int count = 0;
            string modifiedContent = content.Replace("utilize", "use", StringComparison.OrdinalIgnoreCase);

            // Count the number of replacements
            count = (content.Length - modifiedContent.Length) / ("utilize".Length - "use".Length);

            // Write to the output file
            File.WriteAllText(outputFile, modifiedContent);

            Console.WriteLine($"Replacements made: {count}");
            Console.WriteLine($"Modified content written to: {outputFile}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
