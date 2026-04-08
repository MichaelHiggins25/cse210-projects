class Areas
{
    protected static string _namea;
    protected static string _description;
    protected static string _region;
    private int _numOfLands;
    private int _numOfWaters;
    private int _numOfMontains;
    protected List<string> regions = new List<string>();
    protected List<string> areas = new List<string>();
    private int _index;
    public Areas (string namea, string description) 
    {
        _namea = namea;
        _description = description;
        _index = 0;
        _numOfLands = 0;
        _numOfWaters = 0;
        _numOfMontains = 0;
    }
        public Areas (string namea, string description, int index) 
    {
        _namea = namea;
        _index = index;
        _description = description;
        _numOfLands = 0;
        _numOfWaters = 0;
        _numOfMontains = 0;
    }
    public Areas (string description, int index, int numOfLands, int numOfWaters, int numOfMontains) 
    {
        _description = description;
        _index = index;
        _description = "na";
        _numOfLands = numOfLands;
        _numOfWaters = numOfWaters;
        _numOfMontains = numOfMontains;
    }
    public Areas (string namea, int index, string description, int numOfLands, int numOfWaters, int numOfMontains) 
    {
        _namea = namea;
        _index = index;
        _region = regions[index];
        _description = description;
        _numOfLands = numOfLands;
        _numOfWaters = numOfWaters;
        _numOfMontains = numOfMontains;
    }
    public Areas (string namea)
    {
        _namea = namea;
    }
    public string GetArea ()
    {
        return $"Here is a list of your Areas and their regions. \n" + 
        $"Areas: {string.Join("\n", areas)} ;with these regions \n {string.Join("\n", regions)}" + 
        $"\n You have {_numOfLands} of land areas, {_numOfWaters} water areas, and {_numOfMontains} mountain areas.";
    }
}