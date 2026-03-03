class ReflectingActivity: Activity
{
    private string _countDown;
    public ReflectingActivity(string name, string description, string countDown) : base (name, description)
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