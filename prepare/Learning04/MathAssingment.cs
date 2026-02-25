class MathAssingment :Assignment
{
    protected string _textbookSection;
    protected string _problems;
    public MathAssingment (string textbookSection, string problems)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"{_problems}: \n{_textbookSection}";   
    }
}