class Activity
{
    protected string _name;
    protected string _description;

    public string GetWholeActivity()
    {
        return $"{_name}: {_description}";
    }
}