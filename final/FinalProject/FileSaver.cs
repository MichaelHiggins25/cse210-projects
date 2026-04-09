using System;
using System.IO;
class FileSaver: World
{
    private static string _output1; 
    private static string _output2;
    private static string _output3;
    private static string _output4;
    private static string _output5;
    public static void Save(List<string> states, List<string> characters, List<string> organizationl, List<string> areas, List<string> regions)
    {
        foreach (string _i in areas) 
        {
            _output1 = string.Join(", \n", areas);
            Console.WriteLine();
        }
        foreach (string _i in regions) 
        {
            _output2 = string.Join(", \n", regions);
            Console.WriteLine(_output2);
        }
        foreach (string _i in states)
        {
            _output3 = string.Join(", \n", states);
            Console.WriteLine();
        }
        foreach (string _i in organizationl)
        {
            _output4 = string.Join(", \n", organizationl);
            Console.WriteLine();
        }
        foreach (string _i in characters)
        {
            _output5 = string.Join(", \n", characters);
            Console.WriteLine();
        }
    }
}


//public class FileSaver
//{
    // ✅ Save the journal to a file
    //public void SaveToFile(string filename, Journal journal)
    //{
    //    using (StreamWriter writer = new StreamWriter(filename))
    //    {
    //        foreach (Entry e in journal.Entries)
    //        {
    //            // Write each part of the entry
    //            writer.WriteLine(e.GetDate());
    //            writer.WriteLine(e.GetPrompt());
    //            writer.WriteLine(e.GetResponse());
    //            writer.WriteLine("----"); // separator
    //        }
    //    }
    //}

    // ✅ Load the journal from a file
    //public void LoadFromFile(string filename, World)
    //{
    //    if (!File.Exists(filename))
    //    {
    //        Console.WriteLine("File not found.");
    //        return;
    //    }

    //    journal.Entries.Clear(); // start fresh

    //    string[] lines = File.ReadAllLines(filename);

    //    for (int i = 0; i < lines.Length; i += 4)
    //    {
    //        Entry e = new Entry();
    //        e.SetDate(DateTime.Parse(lines[i]));
    //        e.SetPrompt(lines[i + 1]);
    //        e.SetResponse(lines[i + 2]);

    //       journal.Entries.Add(e);
//        }
//    }
//}