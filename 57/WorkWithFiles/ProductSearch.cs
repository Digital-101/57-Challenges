using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static string filePath = "products.json";

    static void Main()
    {
        LoadOrCreateFile();

        while (true)
        {
            Console.Write("What is the product name? ");
            string searchName = Console.ReadLine().Trim();

            JObject jsonData = JObject.Parse(File.ReadAllText(filePath));
            JArray products = (JArray)jsonData["products"];

            var product = products.FirstOrDefault(p =>
                string.Equals((string)p["name"], searchName, StringComparison.OrdinalIgnoreCase));

            if (product != null)
            {
                Console.WriteLine($"\nName: {product["name"]}");
                Console.WriteLine($"Price: ${product["price"]:0.00}");
                Console.WriteLine($"Quantity on hand: {product["quantity"]}\n");
            }
            else
            {
                Console.WriteLine("Sorry, that product was not found in our inventory.");
                Console.Write("Would you like to add it? (y/n): ");
                if (Console.ReadLine().Trim().ToLower() == "y")
                {
                    AddNewProduct(products, searchName);
                }
            }
        }
    }

    static void LoadOrCreateFile()
    {
        if (!File.Exists(filePath))
        {
            var defaultData = new { products = new List<object>() };
            File.WriteAllText(filePath, JsonConvert.SerializeObject(defaultData, Formatting.Indented));
        }
    }

    static void AddNewProduct(JArray products, string productName)
    {
        Console.Write("Enter price: R");
        if (!decimal.TryParse(Console.ReadLine(), out decimal price))
        {
            Console.WriteLine("Invalid price.");
            return;
        }

        Console.Write("Enter quantity: ");
        if (!int.TryParse(Console.ReadLine(), out int quantity))
        {
            Console.WriteLine("Invalid quantity.");
            return;
        }

        var newProduct = new JObject
        {
            ["name"] = productName,
            ["price"] = price,
            ["quantity"] = quantity
        };

        products.Add(newProduct);
        var updatedData = new JObject { ["products"] = products };
        File.WriteAllText(filePath, updatedData.ToString(Formatting.Indented));

        Console.WriteLine("Product added successfully!");
    }
}
