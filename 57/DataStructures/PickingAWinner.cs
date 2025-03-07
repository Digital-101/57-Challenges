using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.DataStructures
{
    class ContestWinner
{
    static void Main()
    {
        List<string> contestants = new List<string>();
        string input;

        // Collect contestant names
        while (true)
        {
            Console.Write("Enter a name: ");
            input = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(input))
                break; // Stop if input is blank

            contestants.Add(input);
        }

        // Ensure we have at least one contestant
        if (contestants.Count == 0)
        {
            Console.WriteLine("No contestants entered. Exiting.");
            return;
        }

        // Pick a random winner
        Random random = new Random();
        int winnerIndex = random.Next(contestants.Count);
        string winner = contestants[winnerIndex];

        Console.WriteLine($"\nThe winner is... {winner}.");
    }
}

}
