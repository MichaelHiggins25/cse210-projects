public class Entry
{
    public string prompt { get; set; }
    public string entrywrite { get; set; }
    public DateTime date { get; set; }

    public override string ToString()
    {
        return $"{date:d}\nPrompt: {prompt}\n{entrywrite}\n";
    }
}
