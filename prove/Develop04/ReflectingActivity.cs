class ReflectingActivity: Activity
{
    private string _response;
    public ReflectingActivity(string name, string description, string response) : base (name, description)
    {
        _name = name;
        _response = response;
        _description = description;
    }

    public string GetActivityResponse()
    {
        return $"{_response}";
    }
}