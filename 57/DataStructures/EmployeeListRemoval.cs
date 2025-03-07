using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.DataStructures
{
    class EmployeeList
{
    static void Main()
    {
        // List of employees
        List<string> employees = new List<string>
        {
            "John Smith",
            "Jackie Jackson",
            "Chris Jones",
            "Amanda Cullen",
            "Jeremy Goodwin"
        };

        // Display the employee list
        Console.WriteLine($"There are {employees.Count} employees:");
        foreach (string employee in employees)
        {
            Console.WriteLine(employee);
        }

        // Ask the user for a name to remove
        Console.Write("\nEnter an employee name to remove: ");
        string nameToRemove = Console.ReadLine();

        // Check if the name exists in the list
        if (employees.Contains(nameToRemove))
        {
            employees.Remove(nameToRemove);
            Console.WriteLine($"\nThere are {employees.Count} employees:");
            foreach (string employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
        else
        {
            Console.WriteLine("Error: Employee not found.");
        }
    }
}

}
