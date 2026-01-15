using System;

int number;

Random randomGenerator = new Random();
int rnumber = randomGenerator.Next(1, 11);
Console.WriteLine("What is the magic number?");
do
{
Console.WriteLine("What is your guess?");
string userInput = Console.ReadLine();
number = int.Parse(userInput);
if (number == rnumber)
    {
        Console.WriteLine("You guessed it!");
    }
else if (number > rnumber)
    {
        Console.WriteLine("Lower");
    }
else if (number < rnumber)
    {
        Console.WriteLine("Higher");
    }
}
while(number != rnumber);
