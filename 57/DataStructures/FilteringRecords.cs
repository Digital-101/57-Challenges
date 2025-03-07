using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.DataStructures
{
    class FilterRecords
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

        // Ask user for search criteria
        Console.WriteLine("Enter a search string (case insensitive): ");
        string searchString = Console.ReadLine().ToLower(); // Case insensitive search string

        Console.WriteLine("Do you want to search by position? (yes/no): ");
        string searchByPosition = Console.ReadLine().ToLower();

        Console.WriteLine("Do you want to filter by separation date (6 months ago or more)? (yes/no): ");
        string filterByDate = Console.ReadLine().ToLower();

        var filteredEmployees = employees.AsEnumerable();

        // Filter by position if the user selects 'yes'
        if (searchByPosition == "yes")
        {
            filteredEmployees = filteredEmployees.Where(e => e.Position.ToLower().Contains(searchString));
        }
        // Filter by last name or first name if the user selects 'no'
        else
        {
            filteredEmployees = filteredEmployees.Where(e =>
                e.FirstName.ToLower().Contains(searchString) || e.LastName.ToLower().Contains(searchString));
        }

        // Filter by separation date if the user selects 'yes'
        if (filterByDate == "yes")
        {
            DateTime sixMonthsAgo = DateTime.Now.AddMonths(-6);
            filteredEmployees = filteredEmployees.Where(e =>
            {
                DateTime separationDate;
                return DateTime.TryParse(e.SeparationDate, out separationDate) && separationDate <= sixMonthsAgo;
            });
        }

        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine("--------- Name ------| ------Position ----|--- Separation Date");
        Console.WriteLine("---------------------|--------------------|----------------");

        // If there are no results
        if (!filteredEmployees.Any())
        {
            Console.WriteLine("No matching records found.");
        }
        else
        {
            // Print matching records
            foreach (var employee in filteredEmployees)
            {
                string separationDate = employee.SeparationDate == "N/A" ? "" : employee.SeparationDate;
                Console.WriteLine($"{employee.FullName,-20} | {employee.Position,-18} | {separationDate}");
            }
        }
    }
}
}
