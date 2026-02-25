class WritingAssignment :Assignment
{
    protected string _title;
    public WritingAssignment(string title)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title}";
    }
}