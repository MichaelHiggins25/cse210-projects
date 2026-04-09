class WaterRegions: Areas
{
    private int _numrivers;
    public List<string> wregion = new List<string>();
    //private new int _regsize;
    public WaterRegions(string name, string description, int numrivers, int regsize) 
        : base (name, description, regsize)
    {
        _namea = name; 
        _description = description;
        _numrivers = numrivers;
        _regsize = regsize;
    }

    public string GetWaterRegion()
    {
        return $"Here is the info of all your land regions. \n" + 
        $"Name: {_namea} \n" +
        $"Description: {_description} \n" +
        $"The size of the area: {_numrivers} \n" ;
    }
}