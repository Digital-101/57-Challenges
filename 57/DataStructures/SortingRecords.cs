using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.DataStructures
{
    class SortingRecords
{
    // Define Employee class to store the employee records
    class Employee
    {
        public string SeparationDate { get; set; }
        public string Position { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        // Constructor to initialize Employee
        public Employee(string separationDate, string position, string lastName, string firstName)
        {
            SeparationDate = separationDate;
            Position = position;
            LastName = lastName;
            FirstName = firstName;
        }

        // Method to return formatted full name
        public string FullName => $"{FirstName} {LastName}";
    }

    static void Main()
    {
        // Create a list of employees with the given data
        List<Employee> employees = new List<Employee>
        {
            new Employee("2016-12-31", "Manager", "Johnson", "John"),
            new Employee("2016-10-05", "Software Engineer", "Xiong", "Tou"),
            new Employee("2015-12-19", "District Manager", "Michaelson", "Michaela"),
            new Employee("N/A", "Programmer", "Jacobson", "Jake"),
            new Employee("N/A", "DBA", "Jackson", "Jacquelyn"),
            new Employee("2015-12-18", "Web Developer", "Weber", "Sally")
        };

        // Prompt user for sorting preference
        Console.WriteLine("How would you like to sort the records?");
        Console.WriteLine("1. Last Name");
        Console.WriteLine("2. Position");
        Console.WriteLine("3. Separation Date");
        string sortChoice = Console.ReadLine();

        // Sort the employee list based on user's choice
        switch (sortChoice)
        {
            case "1":
                // Sort by Last Name
                employees = employees.OrderBy(e => e.LastName).ToList();
                break;
            case "2":
                // Sort by Position
                employees = employees.OrderBy(e => e.Position).ToList();
                break;
            case "3":
                // Sort by Separation Date
                employees = employees.OrderBy(e => e.SeparationDate).ToList();
                break;
            default:
                Console.WriteLine("Invalid choice! Sorting by last name by default.");
                employees = employees.OrderBy(e => e.LastName).ToList();
                break;
        }

        // Print sorted results in tabular format
        Console.WriteLine("\n-Name -------------- |----- Position -----| Separation Date----");
        Console.WriteLine("---------------------|--------------------|-----------------");

        foreach (var employee in employees)
        {
            // Display formatted employee details
            string separationDate = employee.SeparationDate == "N/A" ? "" : employee.SeparationDate;
            Console.WriteLine($"{employee.FullName,-20} | {employee.Position,-18} | {separationDate}");
        }
    }
}
}
