using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        const string filePath = "data.csv";

        // Check if file exists
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"Error: The file '{filePath}' does not exist. Please create it with employee data.");
            return;
        }

        try
        {
            // Read and process the file
            List<Employee> employees = new List<Employee>();

            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] parts = line.Split(',');

                if (parts.Length == 3)
                {
                    employees.Add(new Employee(parts[0], parts[1], int.Parse(parts[2])));
                }
            }

            // Sort employees by salary (highest to lowest)
            employees = employees.OrderByDescending(e => e.Salary).ToList();

            // Determine column widths
            int lastNameWidth = employees.Max(e => e.LastName.Length) + 1;
            int firstNameWidth = employees.Max(e => e.FirstName.Length) + 1;
            int salaryWidth = employees.Max(e => e.Salary.ToString("C0").Length) + 1;

            // Print header
            Console.WriteLine($"{"Last"} {"First"} {"Salary"}");
            Console.WriteLine(new string('-', lastNameWidth + firstNameWidth + salaryWidth));

            // Print sorted employees
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.LastName} {emp.FirstName} {emp.Salary.ToString("C0")}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

// Employee class to store records
class Employee
{
    public string LastName { get; }
    public string FirstName { get; }
    public int Salary { get; }

    public Employee(string lastName, string firstName, int salary)
    {
        LastName = lastName;
        FirstName = firstName;
        Salary = salary;
    }
}
