class Activity
{
    protected string _name;
    protected string _description;
    private int _countDown;
    private string _response;
    public Activity (int countDown)
    {
        _countDown = countDown;
    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public Activity(string name, string description, int countDown)
    {
        _name = name;
        _countDown = countDown;
        _description = description;
    }

    public Activity(string name, string description, string response)
    {
        _name = name;
        _response = response;
        _description = description;
    }


    public string GetWholeActivity()
    {
        return $"{_name}: {_description} \n Timer: {_countDown}";
    }
}