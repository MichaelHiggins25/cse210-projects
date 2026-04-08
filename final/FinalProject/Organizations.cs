class Organizations
{
    private string _people;
    private static int _index;
    private List<string> peopleInIt = new List<string>();
    private List<string> organizationl = new List<string>();

    public Organizations(string people, int index)
    {
        _people = people;
        _index = index;
    }

    public string GetOrganization()
    {
        return "Here is the info on your organizations/company: \n" +
        $"Name of organization/companies: {string.Join("\n", organizationl)} \n" + 
        $"People from these organizations/companies: \n";
    }
}