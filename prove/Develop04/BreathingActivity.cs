class BreathingActivity: Activity
{
    private string _countDown;

    public BreathingActivity(string name, string countDown, string description) : base (name, description)
    {
        _name = name;
        _countDown = countDown;
        _description = description;
    }
    public string GetActivityB()
    {
        return _countDown;
    }
}