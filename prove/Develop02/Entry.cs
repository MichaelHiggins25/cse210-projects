public class Entry
{
    public string _prompt;
    public string entrywrite;
    public DateTime date;

    public override string ToString()
    {
        return $"{date:d}\nPrompt: {_prompt}\n{entrywrite}\n";
    }
}
