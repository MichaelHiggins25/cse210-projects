class World
{
    private string _inarea;
    private string _inregion;
    private string _organizations;
    protected string _states;
    protected string _people;
    private string _output1;
    private string _output2;
    private string _output3;
    private string _output4;
    private string _output5;
    public World()
        {
            _states = "";
            _people = "";
            _organizations = "";
            _inregion = "";
            _inarea = "";
        }
        public World(string states, string organization, string inregion)
    {
        _states = states;
        _people = "";
        _organizations = organization;
        _inregion = inregion;
        _inarea = "";
    }

        public World(string states, string people, string organization, string inregion)
    {
        _states = states;
        _people = people;
        _organizations = organization;
        _inregion = inregion;
        _inarea = "";
    }

    public World(string states, string people, string organization, string inregion, string inarea)
    {
        _states = states;
        _people = people;
        _organizations = organization;
        _inregion = inregion;
        _inarea = inarea;
    }
    public void GetLists (List<string> states, List<string> characters, List<string> organizationl, List<string> areas, List<string> regions)
    {
        foreach (string _i in areas) 
        {
            _output1 = string.Join(", \n", areas);
            Console.WriteLine(_output1);
        }
        foreach (string _i in regions) 
        {
            string _output2 = string.Join(", \n", regions);
            Console.WriteLine(_output2);
        }
        foreach (string _i in states)
        {
            _output1 = string.Join(", \n", states);
            Console.WriteLine(_output3);
        }
        foreach (string _i in organizationl)
        {
            _output1 = string.Join(", \n", organizationl);
            Console.WriteLine(_output4);
        }
        foreach (string _i in characters)
        {
            _output1 = string.Join(", \n", characters);
            Console.WriteLine(_output5);
        }
    }

    public string GetWorld()
    {
        Console.WriteLine("");
        return $"Here is a list of the things in your World. \n" + 
        $"States: {_output3}" +
        $"Organizations: {_output4} \n" + 
        $"Regions: {_output2} \n" +
        $"Areas: {_output1}" +
        $"Characters: {_output5}";
    }
}