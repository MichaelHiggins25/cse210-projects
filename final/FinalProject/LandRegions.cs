class LandRegions: Areas
{
    private string _areasize;
    
    public LandRegions (string name, string description,string areasize)
        : base (name, description)
    {
        _namea = name;
        _description = description;
        _areasize = areasize;
    }
    public LandRegions (string name, string areasize)
        : base (name)
    {
        _namea = name;
        _description = "na";
        _areasize = areasize;
    }

    public string GetLandRegion()
    {
        return $"Here is the info of all your land regions. \n" + 
        $"Name: {_namea} \n" +
        $"Description: {_description} \n" +
        $"The size of the area: {_areasize} \n" ;
    }
}