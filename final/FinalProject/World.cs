class World
{
    public List<int> areas = new List<int>();
    public List<int> regions = new List<int>();
    private string _inarea;
    private string _inregion;
    private string _organizations;
    protected string _states;
    protected string _people;
    public int _index;
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

    public string GetWorld()
    {
        return $"Here is a list of the things in your World. \n" + 
        $"States: {_states} \n" +
        $"Organizations: {_organizations} \n" + 
        $"Regions: {_inregion} \n" +
        $"Areas: {_inarea}" ;
    }
}