using System;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

PromptGenerator prompt = new PromptGenerator();
Journal journal = new Journal();
Console.WriteLine("Welcome to the Journal Program!");

int option = -1;

while (option != 5)
{

    Console.WriteLine("Please select one of the following choices");
    Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
    Console.WriteLine("What would you like to do? ");
    option = int.Parse(Console.ReadLine());

    if (option == 1)// Write
    {
        string question = prompt.GetPrompt();
        Console.WriteLine($"{question}");

        string userEntry = Console.ReadLine();

        Entry entry = new Entry();
        entry._date = DateTime.Now.ToString("MM/dd/yyyy");
        entry._promptText = question;
        entry._entryText = userEntry;

        journal.AddEntry(entry);
    }
    else if (option == 2) // Display
    {
        journal.DisplayAll();
    }
    else if (option == 3) // Load
    {
        Console.WriteLine("\nThese are the files available");
        string extension;
        string[] files = Directory.GetFiles(@"..\Develop02");

        foreach (string f in files)
        {
            string path = Path.GetFileName(f);
            extension = Path.GetExtension(path);
            if (extension == ".csv" || extension == ".txt")
            {
                 Console.WriteLine(path);
            }
        }
        Console.WriteLine("\nWhich file do you want to open?");
        string fileName = Console.ReadLine();
        extension = Path.GetExtension(fileName);
        while (extension == "")
        {
            Console.WriteLine("you must enter the file extension try again (.csv or .txt)");
            fileName = Console.ReadLine();
            extension = Path.GetExtension(fileName);
        }
        journal.LoadFromFile(fileName);

    }
    else if (option == 4) // Save
    {
        Console.WriteLine("What is the filename? ");
        string fileName = Console.ReadLine();
        string extension;
        extension = Path.GetExtension(fileName);

        while (extension == "")
        {
            Console.WriteLine("you must enter the file extension try again (.csv or .txt)");
            fileName = Console.ReadLine();
            extension = Path.GetExtension(fileName);
        }

        journal.SaveToFile(fileName);
    }
}
