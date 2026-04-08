using System;

class Program
{
    static void Main(string[] args)
    {
        World world1 = new World();
        Areas area1 = new Areas();
        area1.GetArea();
        
        Console.WriteLine(area1);
    }
}