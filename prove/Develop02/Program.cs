using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        FileManager fileManager = new FileManager();

        bool running = true;

        while (running)
        {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteEntry(journal, promptGen);
                    break;

                case "2":
                    journal.DisplayJournal();
                    break;

                case "3":
                    Console.Write("Filename to save: ");
                    string saveFile = Console.ReadLine();
                    fileManager.DoSave(saveFile, journal);
                    Console.WriteLine("Journal saved.");
                    break;

                case "4":
                    Console.Write("Filename to load: ");
                    string loadFile = Console.ReadLine();
                    fileManager.GetFile(loadFile, journal);
                    Console.WriteLine("Journal loaded.");
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
    static void WriteEntry(Journal journal, PromptGenerator promptGen)
    {
        string prompt = promptGen.GetRandomPrompt();
        Console.WriteLine($"\n{prompt}");

        Console.Write("> ");
        string response = Console.ReadLine();

        Entry entry = new Entry
        {
            _prompt = prompt,
            entrywrite = response,
            date = DateTime.Now
        };

        journal.WriteJournal(entry);
        Console.WriteLine("Entry added!");
    }
}
