using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.DataStructures
{
    class Magic8Ball
{
    static void Main()
    {
        // List of possible responses
        string[] responses = {
            "Yes",
            "No",
            "Maybe",
            "Ask again later"
        };

        // Prompt the user for a question
        Console.Write("What's your question? ");
        string question = Console.ReadLine();

        // Create a random number generator
        Random rand = new Random();

        // Generate a random index to select a response
        int index = rand.Next(responses.Length);

        // Display the chosen response
        Console.WriteLine(responses[index]);
    }
}

}
