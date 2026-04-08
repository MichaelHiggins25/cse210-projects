class Areas
{
    protected string _namea;
    protected string _description;
    private int _numOfLands;
    private int _numOfWaters;
    private int _numOfMontains;
    protected string _areasize;
    protected List<int> regions = new List<int>();
    protected List<int> areas = new List<int>();

    public void CreateArea(string region, string namea, string description, int numOfLands, int numOfWaters, int numOfMontains) 
    {
        _namea = namea;
        _description = description;
        _numOfLands = numOfLands;
        _numOfWaters = numOfWaters;
        _numOfMontains = numOfMontains;
    }
    public string GetArea ()
    {
        return $"Here is a list of your Areas and their regions. \n" + 
        $"Areas: {string.Join("\n", areas)} ;with these regions \n {string.Join("\n", regions)}" + 
        $"You have {_numOfLands} of land areas, {_numOfWaters} water areas, and {_numOfMontains} mountain areas.";
    }
}