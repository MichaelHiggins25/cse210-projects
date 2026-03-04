class ReflectingActivity: Activity
{
    private string _response;
        public ReflectingActivity(string name, string description) : base (name, description)
    {
        _name = name;
        _response = "Please write a response";
        _description = description;
    }

    public ReflectingActivity(string name, string description, string response) : base (name, description)
    {
        _name = name;
        _response = response;
        _description = description;
    }

    public string GetActivityResponse()
    {
        return $"\n{_response}";
    }
    public string GetActivitySummary()
    {
        return $"{_name}: {_description}";
    }
}