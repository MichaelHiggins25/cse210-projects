class Areas: Program 
{
    protected static string _namea;
    protected static string _description;
    private int _numOfLands;
    private int _numOfWaters;
    private int _numOfMontains;
    private int _index;
    protected int _regsize;
    public List<string> areasl = new List<string>();
    public List<string> regionsl = new List<string>();
    

    public Areas ()
    {
        _namea = "";
        _index = 0;
        _description = "";
        _numOfLands += 0;
        _numOfWaters += 0;
        _numOfMontains += 0;
    }
    public Areas (string namea)
    {
        _namea = namea;
    }
        public Areas (string namea, int index, int regsize)
    {
        _namea = namea;
        _index = 0;
        _description = "";
        _regsize = regsize;
    }
    public Areas (string namea, string description, int regsize) 
    {
        _namea = namea;
        _description = description;
        _index = 0;
        _regsize = regsize;
        _numOfLands = 0;
        _numOfWaters = 0;
        _numOfMontains = 0;
    }
        public Areas (string namea, int index, string description, int regsize) 
    {
        _namea = namea;
        _index = index;
        _description = description;
        _regsize = regsize; 
        _numOfLands = 0;
        _numOfWaters = 0;
        _numOfMontains = 0;
    }
        public Areas (string namea, string description, int index, int regsize) 
    {
        _namea = namea;
        _index = index;
        _description = description;
        _regsize = regsize;
        _numOfLands = 0;
        _numOfWaters = 0;
        _numOfMontains = 0;
    }
    public Areas (string description, int index, int numOfLands, int numOfWaters, int numOfMontains, int regsize) 
    {
        _description = description;
        _index = index;
        _description = "na";
        _regsize = regsize; 
        _numOfLands = numOfLands;
        _numOfWaters = numOfWaters;
        _numOfMontains = numOfMontains;
    }
    public Areas (string namea, string description, int numOfLands, int numOfWaters, int numOfMontains, int index, int regsize) 
    {
        _namea = namea;
        _index = index;
        _description = description;
        _regsize = regsize; 
        _numOfLands = numOfLands;
        _numOfWaters = numOfWaters;
        _numOfMontains = numOfMontains;
    }

    public string GetArea ()
    {
        return $"Here is a list of your Areas and their regions. \n" + 
        $"Areas: {string.Join("\n", areasl)} ;with these regions \n {string.Join("\n", regionsl)}" + 
        $"The size of the area: {_regsize}"+
        $"\n You have {_numOfLands} of land areas, {_numOfWaters} water areas, and {_numOfMontains} mountain areas.";
    }
}