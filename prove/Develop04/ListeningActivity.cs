class ListingActivity: Activity
{
    public ListingActivity(string name, string description): base (_name,_description)
    {
        _name = name;
        _description = description;
        _countDown = 0;

    }
    public ListingActivity(string name, string description, int countDown): base (_name, _description, _countDown)
    {
        _name = name;
        _description = description;
        _countDown = countDown;
    }
    public string GetActivityTimer()
    {
        return $"{_countDown}";
    }
    public string GetActivitySummary()
    {
        return $"{_name}: {_description}";
    }
}