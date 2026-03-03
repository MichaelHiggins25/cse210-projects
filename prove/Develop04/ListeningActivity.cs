class ListeningActivity: Activity
{
    private string _response;

    public ListeningActivity(string name, string description, string response) : base (name, description)
    {
        _name = name;
        _response = response;
        _description = description;
    }

    public string GetActivityB()
    {
        return _response;
    }
}