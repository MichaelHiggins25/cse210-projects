class States
{
    private string _people;
    private int _index;
    private string _description;
    private List<string> peopleInIt = new List<string>();
    private List<string> statesl = new List<string>();

        public States(string people, string description,int index)
    {
        _people = people;
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