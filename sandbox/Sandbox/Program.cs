using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World!");

        // Counter myCounter = new Counter();
        // myCounter.Run();

        Message n1 = new Message();
        n1._message = "Send Help!";
        n1._priority = 1;
        
        Message n2 = new Message();
        n1._message = "Ahhhhhhhh!";
        n1._priority = 3;
        Console.WriteLine(n2.GetMessage());
        Console.WriteLine(n1.GetMessage());
        
    }
}

