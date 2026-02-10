public class Entry
{
    public string _prompt { get; set; }
    public string entrywrite { get; set; }
    public DateTime date { get; set; }

    public override string ToString()
    {
        return $"{date:d}\nPrompt: {_prompt}\n{entrywrite}\n";
    }
}
