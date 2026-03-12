class ReflectingActivity: Activity
{
        public ReflectingActivity(string name, string description) : base (_name, _description)
    {
        _name = name;
        _response = "Please write a response";
        _description = description;
    }

    public ReflectingActivity(string name, string description, string response) : base (_name, _description, _response)
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