using System;

class Program
{
    static void Main()
    {
        bool running = true;
        while (running){
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
            {
            case 1:
                
                break;
            case 2:
                
                break;
            case 3:
                
                break;
            case 4:

                break;
            case 5: 
                running = false;
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
            }
        }
    }
}