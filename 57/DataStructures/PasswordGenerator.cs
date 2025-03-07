using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.DataStructures
{
    class PasswordGenerator
{
    static Random random = new Random();

    static void Main()
    {
        Console.Write("What's the minimum length? ");
        int minLength = int.Parse(Console.ReadLine());

        Console.Write("How many special characters? ");
        int specialCharCount = int.Parse(Console.ReadLine());

        Console.Write("How many numbers? ");
        int numberCount = int.Parse(Console.ReadLine());

        string password = GeneratePassword(minLength, specialCharCount, numberCount);
        Console.WriteLine("\nYour password is: " + password);
    }

    static string GeneratePassword(int minLength, int specialCharCount, int numberCount)
    {
        string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string numbers = "0123456789";
        string specialChars = "!@#$%^&*()_-+=<>?";

        List<char> password = new List<char>();

        // Add special characters
        for (int i = 0; i < specialCharCount; i++)
            password.Add(specialChars[random.Next(specialChars.Length)]);

        // Add numbers
        for (int i = 0; i < numberCount; i++)
            password.Add(numbers[random.Next(numbers.Length)]);

        // Add remaining letters to meet min length
        int remainingChars = Math.Max(minLength - password.Count, 0);
        for (int i = 0; i < remainingChars; i++)
            password.Add(letters[random.Next(letters.Length)]);

        // Shuffle the password to randomize order
        password = password.OrderBy(x => random.Next()).ToList();

        return new string(password.ToArray());
    }
}

}
