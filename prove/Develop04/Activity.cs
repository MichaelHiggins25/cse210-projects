class Activity
{
    protected string _name;
    protected string _description;
   private string _countDown;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public Activity(string name, string description, string countDown)
    {
        _name = name;
        string _countDown = countDown;
        _description = description;
    }


    public string GetWholeActivity()
    {
        return $"{_name}: {_description} \n Timer: {_countDown}";
    }
}