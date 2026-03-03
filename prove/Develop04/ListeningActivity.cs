class ListeningActivity: Activity
{
    private int _countDown;

    public ListeningActivity(string name, int countDown, string description) : base (name, description)
    {
        _name = name;
        _countDown = countDown;
        _description = description;
    }
    public string GetActivityTimer()
    {
        return $"{_countDown}";
    }
}