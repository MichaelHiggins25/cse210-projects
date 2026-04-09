class States: World
{
    private new string _people;
    private int _index;
    private string _description;
    private List<string> peopleInIt = new List<string>();
    private List<string> statesl = new List<string>();
    public States()
    {
        _people = "";
        _description = "";
        _index = 0;
    }
        public States(string people, string description,int index)
    {
        _people = people;
        _description = description;
        _index = index;
    }

    public States(string people, string description)
    {
        _people = people;
        _description = description;
        _index = 0;
    }

    public States(string people)
    {
        _people = people;
        _description = "na";
        _index = 0;
    }

    public States(string description, int index)
    {
        _people = "na";
        _description = description;
        _index = index;
    }

    public string GetStates()
    {
        return "Here is the info on your organizations/company: \n" +
        $"Name of organization/companies: {string.Join("\n", statesl)} \n" + 
        $"People from these organizations/companies: {string.Join("\n", peopleInIt)}\n";
    }
}