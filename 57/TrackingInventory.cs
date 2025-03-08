using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class Program
{
    static string jsonFile = "inventory.json";
    static List<Item> inventory = new List<Item>();

    class Item
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public decimal Value { get; set; }
    }

    static void Main()
    {
        LoadInventory();

        while (true)
        {
            Console.WriteLine("\nInventory Tracker");
            Console.WriteLine("=====================");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. View Inventory");
            Console.WriteLine("3. Export to CSV");
            Console.WriteLine("4. Export to HTML");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            Console.WriteLine();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddItem();
                    break;
                case "2":
                    DisplayInventory();
                    break;
                case "3":
                    ExportToCsv();
                    break;
                case "4":
                    ExportToHtml();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void LoadInventory()
    {
        if (File.Exists(jsonFile))
        {
            string json = File.ReadAllText(jsonFile);
            inventory = JsonConvert.DeserializeObject<List<Item>>(json) ?? new List<Item>();
        }
    }

    static void SaveInventory()
    {
        string json = JsonConvert.SerializeObject(inventory, Formatting.Indented);
        File.WriteAllText(jsonFile, json);
    }

    static void AddItem()
    {
        Console.Write("Enter item name: ");
        string name = Console.ReadLine();

        Console.Write("Enter serial number: ");
        string serialNumber = Console.ReadLine();

        decimal value;
        while (true)
        {
            Console.Write("Enter item value: R");
            if (decimal.TryParse(Console.ReadLine(), out value) && value >= 0)
                break;
            Console.WriteLine("Invalid value. Enter a positive number.");
        }

        inventory.Add(new Item { Name = name, SerialNumber = serialNumber, Value = value });
        SaveInventory();
        Console.WriteLine("Item added successfully.");
    }

    static void DisplayInventory()
    {
        Console.WriteLine("\nInventory List:");
        Console.WriteLine("Value\tSerial Number\tName");
        Console.WriteLine("------------------------------------");
        foreach (var item in inventory)
        {
            Console.WriteLine($"R{item.Value:F2}\t{item.SerialNumber}\t{item.Name}");
        }
    }

    static void ExportToCsv()
    {
        string csvFile = "inventory.csv";
        using (StreamWriter writer = new StreamWriter(csvFile))
        {
            writer.WriteLine("Value,Serial Number,Name");
            foreach (var item in inventory)
            {
                writer.WriteLine($"{item.Value:F2},{item.SerialNumber},{item.Name}");
            }
        }
        Console.WriteLine($"Inventory exported to {csvFile}");
    }

    static void ExportToHtml()
    {
        string htmlFile = "inventory.html";
        using (StreamWriter writer = new StreamWriter(htmlFile))
        {
            writer.WriteLine("<html><body><h2>Inventory List</h2>");
            writer.WriteLine("<table border='1'><tr><th>Value</th><th>Serial Number</th><th>Name</th></tr>");
            foreach (var item in inventory)
            {
                writer.WriteLine($"<tr><td>R{item.Value:F2}</td><td>{item.SerialNumber}</td><td>{item.Name}</td></tr>");
            }
            writer.WriteLine("</table></body></html>");
        }
        Console.WriteLine($"Inventory exported to {htmlFile}");
    }
}
