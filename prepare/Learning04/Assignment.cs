
class Assignment
{
    private string _studentName;
    private string topic;

    public string GetSummary()
    {
        return $"Class: {topic}\n Student Name: {_studentName}";
    }
}