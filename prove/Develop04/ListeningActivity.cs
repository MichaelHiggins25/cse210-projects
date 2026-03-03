class ListeningActivity: Activity
{
    private int _countDown;
    public ListeningActivity(string name, string description): base (_name,_description)
    {
        _name = name;
        _description = description;
        _countDown = 0;

    }
    public ListeningActivity(string name, string description, int countDown): base (_name, _description)
    {
        _name = name;
        _description = description;
        _countDown = countDown;
    }
    public string GetActivityTimer()
    {
        return $"{_countDown}";
    }
}