using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        // Prompt user for city
        Console.Write("Enter city: ");
        string city = Console.ReadLine();

        string apiKey = "c75f55ab119313741716b67c5a69e9c1"; // Replace with your API key
        string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&units=imperial&appid={apiKey}";

        try
        {
            // Make the API request
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            // Read the response data
            string data = await response.Content.ReadAsStringAsync();
            JObject jsonData = JObject.Parse(data);

            // Extract and display weather info
            string description = jsonData["weather"][0]["description"].ToString();
            double temperature = (double)jsonData["main"]["temp"];
            double tempCelsius = (temperature - 32) * 5 / 9; // Convert Fahrenheit to Celsius
            int humidity = (int)jsonData["main"]["humidity"];
            string windDirection = GetWindDirection((int)jsonData["wind"]["deg"]);

            Console.WriteLine($"{city} weather:");
            Console.WriteLine($"Temperature: {temperature} °F ({tempCelsius:F1} °C)");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Humidity: {humidity}%");
            Console.WriteLine($"Wind: {windDirection}");
            Console.WriteLine($"Coat needed? {(temperature < 60 ? "Yes" : "No")}");
            Console.WriteLine($"Umbrella needed? {(description.Contains("rain") ? "Yes" : "No")}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    // Function to convert wind direction from degrees to cardinal directions
    static string GetWindDirection(int degrees)
    {
        if (degrees >= 337.5 || degrees < 22.5) return "North";
        if (degrees >= 22.5 && degrees < 67.5) return "Northeast";
        if (degrees >= 67.5 && degrees < 112.5) return "East";
        if (degrees >= 112.5 && degrees < 157.5) return "Southeast";
        if (degrees >= 157.5 && degrees < 202.5) return "South";
        if (degrees >= 202.5 && degrees < 247.5) return "Southwest";
        if (degrees >= 247.5 && degrees < 292.5) return "West";
        return "Northwest";
    }
}
