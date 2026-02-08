public class FileManager
{
    public void DoSave(string filename, Journal journal)
    {
        using StreamWriter writer = new StreamWriter(filename);

        foreach (Entry entry in journal.Entries)
        {
            writer.WriteLine(entry.date);
            writer.WriteLine(entry.prompt);
            writer.WriteLine(entry.entrywrite);
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
                date = DateTime.Parse(lines[i]),
                prompt = lines[i + 1],
                entrywrite = lines[i + 2]
            };

            journal.WriteJournal(entry);
        }
    }
}
