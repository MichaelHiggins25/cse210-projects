using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int usenumber = -1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (usenumber != 0) 
        {
            Console.WriteLine("Enter number:");
            string userInput = Console.ReadLine();
            usenumber = int.Parse(userInput);
            numbers.Add(usenumber);
        }
        int sum = numbers.Sum();
        Console.WriteLine(sum);
    }
}