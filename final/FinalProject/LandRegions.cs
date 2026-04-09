class LandRegions: Areas //also known as grassland or plains
{
    //private int regsize;
    public LandRegions (string name, string description, int regsize) 
        : base (name, description, regsize)
    {
        _namea = name;
        _description = description;
        _regsize = regsize;
    }
    public LandRegions (string name) 
        : base (name)
    {
        _namea = name;
        _description = "na";
        _regsize = 0;
        
    }

    public string GetLandRegion()
    {
        return $"Here is the info of all your land regions. \n" + 
        $"Name: {_namea} \n" +
        $"Description: {_description} \n" +
        $"The size of the area: {_regsize} \n" ;
    }
}