using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Site name: ");
        string siteName = Console.ReadLine();

        Console.Write("Author: ");
        string author = Console.ReadLine();

        Console.Write("Do you want a folder for JavaScript? (y/n): ");
        bool createJsFolder = Console.ReadLine().Trim().ToLower() == "y";

        Console.Write("Do you want a folder for CSS? (y/n): ");
        bool createCssFolder = Console.ReadLine().Trim().ToLower() == "y";

        // Define the root folder
        string rootPath = Path.Combine(Directory.GetCurrentDirectory(), siteName);

        // Create main folder
        Directory.CreateDirectory(rootPath);
        Console.WriteLine($"Created {rootPath}");

        // Create index.html file
        string indexPath = Path.Combine(rootPath, "index.html");
        string htmlContent = $@"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""author"" content=""{author}"">
    <title>{siteName}</title>
</head>
<body>
    <h1>Welcome to {siteName}</h1>
</body>
</html>";

        File.WriteAllText(indexPath, htmlContent);
        Console.WriteLine($"Created {indexPath}");

        // Create JavaScript folder if requested
        if (createJsFolder)
        {
            string jsPath = Path.Combine(rootPath, "js");
            Directory.CreateDirectory(jsPath);
            Console.WriteLine($"Created {jsPath}/");
        }

        // Create CSS folder if requested
        if (createCssFolder)
        {
            string cssPath = Path.Combine(rootPath, "css");
            Directory.CreateDirectory(cssPath);
            Console.WriteLine($"Created {cssPath}/");
        }

        Console.WriteLine("Website structure generated successfully!");
    }
}
