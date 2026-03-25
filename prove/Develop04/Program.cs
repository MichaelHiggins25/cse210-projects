using System;

class Program
{
    private static string activity = "";
    public static string dashes = "-------------------------------------------------------------------------";
    public static string arrowndash = $"-------------------------------→ {activity}------------------------------";
    static void Main(string[] args)
    {
        BreathingActivity activity1 = new BreathingActivity("Deep Breaths", "breath in and out deeply until time is up.", 10);
        ListingActivity activity2 = new ListingActivity("List", "",60);
        ReflectingActivity activity3 = new ReflectingActivity("Reflecting on today","What was the most fun thing you did today?");
        Console.WriteLine(dashes);
        Console.WriteLine(activity1);
        Console.WriteLine(activity2);
        Console.WriteLine(activity3);
        
    }
}

