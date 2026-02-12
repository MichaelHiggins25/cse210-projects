public class FileManager
{
    public void DoSave(string filename, Journal journal)
    {
        using StreamWriter writer = new StreamWriter(filename);

        foreach (Entry entry in journal.Entries)
        {
            writer.WriteLine(entry.Date);
            writer.WriteLine(entry.Prompts);
            writer.WriteLine(entry.EntryWrite);
            writer.WriteLine("--------------------------");
        }
    }

    public void GetFile(string filename, Journal journal)
    {
        journal.Entries.Clear();

        string[] lines = File.ReadAllLines(filename);
        for (int i = 0; i < lines.Length; i += 4)
        {
            Entry entry = new Entry
            {
                Date = DateTime.Parse(lines[i]),
                Prompts = lines[i + 1],
                EntryWrite = lines[i + 2]
            };

            journal.WriteJournal(entry);
        }
    }
}
