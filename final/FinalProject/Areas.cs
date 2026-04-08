abstract class Areas
{
    public string _namea;
    public string _description;
    private int _numOfLands;
    private int _numOfWaters;
    private int _numOfMontains;
    protected List<int> regions = new List<int>();
    protected List<int> areas = new List<int>();
    public abstract void CreateRegions(string name, string description);
    public void CreateArea(string region, string namea, string description, int numOfLands, int numOfWaters, int numOfMontains)
    {
        
    }
    public string GetArea ()
    {
        return $"Here is a list of your Areas and their regions. \n" + 
        $"Areas: {string.Join("\n", areas)} ;with these regions \n {string.Join("\n", regions)}" + 
        $"You have {_numOfLands} of land areas, {_numOfWaters} water areas, and {_numOfMontains} mountain areas.";
    }
}