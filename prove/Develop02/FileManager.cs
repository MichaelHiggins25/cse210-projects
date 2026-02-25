public class FileManager
{
    public void DoSave(string filename, Journal journal)
    {
        using StreamWriter writer = new StreamWriter(filename);

        foreach (Entry entry in journal.Entries)
        {
            writer.WriteLine(entry._date);
            writer.WriteLine(entry._prompts);
            writer.WriteLine(entry._entryWrite);
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
                _date = DateTime.Parse(lines[i]),
                _prompts = lines[i + 1],
                _entryWrite = lines[i + 2]
            };

            journal.WriteJournal(entry);
        }
    }
}
