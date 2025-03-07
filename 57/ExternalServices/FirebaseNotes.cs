using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static string configPath = "config.json";
    static string firebaseUrl;
    static string apiKey;

    static async Task Main(string[] args)
    {
        // Load the configuration file
        LoadConfig();

        // User command input
        while (true)
        {
            Console.WriteLine("\nEnter a command: 'new' to add a note or 'show' to view all notes. Type 'exit' to quit.");
            string command = Console.ReadLine().ToLower();

            if (command == "new")
            {
                Console.WriteLine("Enter your note:");
                string note = Console.ReadLine();

                if (!string.IsNullOrEmpty(note))
                {
                    await SaveNoteAsync(note);
                }
                else
                {
                    Console.WriteLine("Note cannot be empty.");
                }
            }
            else if (command == "show")
            {
                await ShowNotesAsync();
            }
            else if (command == "exit")
            {
                Console.WriteLine("Exiting the program.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid command. Please try again.");
            }
        }
    }

    // Load the Firebase configuration from the config file
    static void LoadConfig()
    {
        if (!File.Exists(configPath))
        {
            Console.WriteLine("Config file missing!");
            Environment.Exit(1);
        }

        string json = File.ReadAllText(configPath);
        JObject config = JObject.Parse(json);
        firebaseUrl = config["firebaseUrl"].ToString();
        apiKey = config["apiKey"].ToString();
    }

    // Save a new note to Firebase
    static async Task SaveNoteAsync(string note)
    {
        using (HttpClient client = new HttpClient())
        {
            string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            var data = new { timestamp, note };
            string json = JsonConvert.SerializeObject(data);

            var content = new StringContent(json, Encoding.UTF8, "application/json");
            string url = $"{firebaseUrl}/notes.json?auth={apiKey}";

            HttpResponseMessage response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
                Console.WriteLine("Your note was saved.");
            else
                Console.WriteLine("Failed to save note.");
        }
    }

    // Display all notes saved in Firebase
    static async Task ShowNotesAsync()
    {
        using (HttpClient client = new HttpClient())
        {
            string url = $"{firebaseUrl}/notes.json?auth={apiKey}";

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                if (json == "null")
                {
                    Console.WriteLine("No notes found.");
                    return;
                }

                JObject notes = JObject.Parse(json);
                foreach (var note in notes)
                {
                    string timestamp = note.Value["timestamp"].ToString();
                    string text = note.Value["note"].ToString();
                    Console.WriteLine($"{timestamp} - {text}");
                }
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Failed to fetch notes. Status Code: {response.StatusCode}, Message: {errorMessage}");
            }
        }
    }

}
