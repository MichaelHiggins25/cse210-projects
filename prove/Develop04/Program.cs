using System;

class Program
{
    private static string activity = "";
    public string dashes = "-------------------------------------------------------------------------";
    public string arrowndash = $"-------------------------------→ {activity}------------------------------";
    static void Main(string[] args)
    {
        BreathingActivity activity1 = new BreathingActivity("", "");
        BreathingActivity activity2 = new BreathingActivity("", "");
        ListeningActivity activity3 = new ListeningActivity("", "");
        ReflectingActivity activity4 = new ReflectingActivity("","","");


        Console.WriteLine(activity1);
        Console.WriteLine(activity2);
        Console.WriteLine(activity3);
        Console.WriteLine(activity4);


    }
}

