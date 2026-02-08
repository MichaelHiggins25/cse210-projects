public class Entry
{
    public string prompt { get; set; }
    public string entrywrite { get; set; }
    public DateTime Date { get; set; }

    public override string ToString()
    {
        return $"{Date:d}\nPrompt: {prompt}\n{entrywrite}\n";
    }
}
