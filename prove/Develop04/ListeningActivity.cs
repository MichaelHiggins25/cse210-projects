class ListeningActivity: Activity
{
    private int _countDown;
    public ListeningActivity(int countDown) : base(countDown)
    {
        _countDown = countDown;        
    }
    public ListeningActivity(string name,string description): base (name, description)
    {
        _name = name;
        _description = description;
    }
    public string GetActivityTimer()
    {
        return $"{_countDown}";
    }
}