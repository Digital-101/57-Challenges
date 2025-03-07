using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();
        string url = "http://api.open-notify.org/astros.json";

        // Fetch the data from the API
        HttpResponseMessage response = await client.GetAsync(url);
        string data = await response.Content.ReadAsStringAsync();

        // Parse the JSON response
        JObject jsonData = JObject.Parse(data);

        // Display the number of people in space
        Console.WriteLine($"There are {jsonData["number"]} people in space right now:");

        // Print header for the table
        Console.WriteLine("Name\t\t\t| Craft");
        Console.WriteLine("--------------------|------");

        // Loop through each person and print their name and spacecraft
        foreach (var astronaut in jsonData["people"])
        {
            Console.WriteLine($"{astronaut["name"]}\t\t\t| {astronaut["craft"]}");
        }
    }
}
