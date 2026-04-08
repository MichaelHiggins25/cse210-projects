class WaterRegions: Areas
{
    private int _numrivers;
    public WaterRegions(string name, string description, int numrivers) 
        : base (name, description)
    {
        _numrivers = numrivers;
    }

    public string GetWaterRegion()
    {
        return $"Here is the info of all your land regions. \n" + 
        $"Name: {_namea} \n" +
        $"Description: {_description} \n" +
        $"The size of the area: {_numrivers} \n" ;
    }
}