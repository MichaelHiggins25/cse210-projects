class Organizations: World
{
    private new string _people;
    private string _description;
    private List<string> peopleInIt = new List<string>();
    private List<string> organizationl = new List<string>();
    public Organizations()
    {
        _people = "";
        _description = "";
        _index = 0;
    }

    public Organizations(string people, string description, int index)
    {
        _people = people;
        _description = description;
        _index = index;
    }

    public Organizations(string people, string description)
    {
        _people = people;
        _description = description;
        _index = 0;
    }

    public Organizations(string people)
    {
        _people = people;
        _description = "na";
        _index = 0;
    }

    public Organizations(string description, int index)
    {
        _people = "na";
        _description = description;
        _index = index;
    }
    
    public string GetOrganization()
    {
        return "Here is the info on your organizations/company: \n" +
        $"Name of organization/companies: {string.Join("\n", organizationl)} \n" + 
        $"People from these organizations/companies: {string.Join("\n", peopleInIt)}\n";
    }
}