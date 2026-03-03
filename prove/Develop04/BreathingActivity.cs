class BreathingActivity: Activity
{
    private int _countDown;

    public BreathingActivity(string name, string description) : base (name, description)
    {
        _name = name;
        _description = description;
    }

    public BreathingActivity(string name, int countDown, string description) : base (name, description)
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