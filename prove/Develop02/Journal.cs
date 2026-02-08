using System.IO;
using System.Collections.Generic;
public class Journal
{
    public List<Entry> Entries { get; } = new List<Entry>();

    public void WriteJournal(Entry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in Entries)
        {
            Console.WriteLine(entry);
        }
    }
}
