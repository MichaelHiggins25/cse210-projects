using System;

class Program
{
    private static string activity = "";
    public string dashes = "-------------------------------------------------------------------------";
    public string arrowndash = $"-------------------------------→ {activity}------------------------------";
    static void Main(string[] args)
    {
        BreathingActivity activity1 = new BreathingActivity("Deep Breaths", "breath in and out deeply until time is up.", 10);
        ListeningActivity activity2 = new ListeningActivity("Listening to Music", "listening to music util time is up. Try to pick out what instruments are being used.",60);
        ListeningActivity activity3 = new ListeningActivity("Listen to the World", "listen to the world around you and pick out the different sound you hear or may be hearing. Can you tell where they came from?");
        ReflectingActivity activity4 = new ReflectingActivity("Reflecting on today","What was the most fun thing you did today?");

        Console.WriteLine(activity1);
        Console.WriteLine(activity2);
        Console.WriteLine(activity3);
        Console.WriteLine(activity4);
    }
}

