public class Entry
{
    public string Prompts;
    public string EntryWrite;
    public DateTime Date;

    public override string ToString()
    {
        return $"{Date:d}\nPrompt: {Prompts}\n{EntryWrite}\n";
    }
}
