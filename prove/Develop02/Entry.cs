public class Entry
{
    public string _prompts;
    public string _entryWrite;
    public DateTime _date;

    public override string ToString()
    {
        return $"{_date:d}\nPrompt: {_prompts}\n{_entryWrite}\n";
    }
}
