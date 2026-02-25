class MathAssingment :Assignment
{
    protected string _textbookSection;
    protected string _problems;
    public MathAssingment (string studentName, string topic, string textbookSection, string problems)
    : base(studentName,topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"{_problems}: \n{_textbookSection}";   
    }
}