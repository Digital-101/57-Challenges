using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        Console.Write("Enter the name of a movie: ");
        string movieTitle = Console.ReadLine();

        string apiKey = "57177e95"; // Replace with your OMDb API key
        string url = $"http://www.omdbapi.com/?t={Uri.EscapeDataString(movieTitle)}&apikey={apiKey}";

        using (HttpClient client = new HttpClient())
        {
            try
            {
                string response = await client.GetStringAsync(url);
                JObject movieData = JObject.Parse(response);

                if (movieData["Response"].ToString() == "True")
                {
                    string title = movieData["Title"].ToString();
                    string year = movieData["Year"].ToString();
                    string rating = movieData["Rated"].ToString();
                    string runtime = movieData["Runtime"].ToString();
                    string plot = movieData["Plot"].ToString();
                    string imdbRating = movieData["imdbRating"].ToString();

                    Console.WriteLine($"\nTitle: {title}");
                    Console.WriteLine($"Year: {year}");
                    Console.WriteLine($"Rating: {rating}");
                    Console.WriteLine($"Running Time: {runtime}");
                    Console.WriteLine($"Description: {plot}");
                    Console.WriteLine($"IMDb Rating: {imdbRating}");

                    if (double.TryParse(imdbRating, out double ratingValue))
                    {
                        if (ratingValue >= 8.0)
                        {
                            Console.WriteLine("You should watch this movie right now!");
                        }
                        else if (ratingValue < 5.0)
                        {
                            Console.WriteLine("You should avoid this movie at all costs.");
                        }
                        else
                        {
                            Console.WriteLine("This movie has mixed reviews; watch at your discretion.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Movie not found. Please check the title and try again.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
