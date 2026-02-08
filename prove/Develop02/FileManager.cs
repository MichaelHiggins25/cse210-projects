public class FileManager
{
    public void Save(string filename, Journal journal)
    {
        using StreamWriter writer = new StreamWriter(filename);

        foreach (Entry entry in journal.Entries)
        {
            writer.WriteLine(entry.Date);
            writer.WriteLine(entry.prompt);
            writer.WriteLine(entry.entrywrite);
            writer.WriteLine("--------------------------");
        }
    }

    public void Load(string filename, Journal journal)
    {
        journal.Entries.Clear();

        string[] lines = File.ReadAllLines(filename);
        for (int i = 0; i < lines.Length; i += 4)
        {
            Entry entry = new Entry
            {
                Date = DateTime.Parse(lines[i]),
                prompt = lines[i + 1],
                entrywrite = lines[i + 2]
            };

            journal.WriteJournal(entry);
        }
    }
}
