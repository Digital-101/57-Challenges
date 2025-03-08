using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DataStructures50
{

    class TriviaGame
    {
        // Structure to store trivia question data
        class TriviaQuestion
        {
            public string Question { get; set; }
            public string Correct { get; set; }
            public List<string> Options { get; set; }
        }

        static void Main()
        {
            // Load questions from the JSON file
            List<TriviaQuestion> questions = LoadQuestions("trivia.json");
            if (questions.Count == 0)
            {
                Console.WriteLine("No questions found! Please check your trivia file.");
                return;
            }

            int score = 0;

            while (questions.Count > 0)
            {
                Console.Clear();
                Random rnd = new Random();
                int index = rnd.Next(questions.Count);
                TriviaQuestion question = questions[index];

                Console.WriteLine($"Question: {question.Question}");

                // Shuffle and display options
                List<string> shuffledOptions = new List<string>(question.Options);
                shuffledOptions.Sort((a, b) => rnd.Next(-1, 2));

                for (int i = 0; i < shuffledOptions.Count; i++)
                    Console.WriteLine($"{i + 1}. {shuffledOptions[i]}");

                Console.Write("Your answer (1-4): ");
                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid input! Game Over.");
                    break;
                }

                if (shuffledOptions[choice - 1] == question.Correct)
                {
                    score++;
                    Console.WriteLine("✅ Correct!\nPress any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"❌ Wrong! The correct answer was: {question.Correct}");
                    Console.WriteLine($"Final Score: {score}");
                    break;
                }

                // Remove the question from the list
                questions.RemoveAt(index);
            }

            Console.WriteLine("Game Over. Thanks for playing!");
        }

        // Method to load questions from JSON
        static List<TriviaQuestion> LoadQuestions(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Trivia file not found!");
                return new List<TriviaQuestion>();
            }

            string json = File.ReadAllText(filePath);
            var data = JsonConvert.DeserializeObject<Dictionary<string, List<TriviaQuestion>>>(json);
            return data.ContainsKey("questions") ? data["questions"] : new List<TriviaQuestion>();
        }
    }
}
