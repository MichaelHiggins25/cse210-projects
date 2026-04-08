class Areas
{
    private string _region;
    private string _namea;
    private string _decription;
    private int _numOfLands;
    private int _numOfWaters;
    private int _numOfMontains;
    protected List<int> regions = new List<int>();

    public void CreateArea(string region, string namea, string decription, string numOfLand, string numOfWater, string numOfMontains)
    {
        
    }
    public string GetArea ()
    {
        return $"Here is a list of your Areas and their regions. \n" + 
        $"Areas: {_namea} with these regions \n {string.Join("\n", regions)}";
    }
}