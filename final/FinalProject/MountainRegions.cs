class MontainsRegions
{
    private new string _namea;  
    private new string _description;  
    private new string _areasize;
    public void LandRegions(string name, string description,string areasize)
    {
        _namea = name;
        _description = description;
        _areasize = areasize;
    }

    public string GetMountainRegion()
    {
        return $"Here is the info of all your land regions. \n" + 
        $"Name: {_namea} \n" +
        $"Description: {_description} \n" +
        $"The size of the area: {_areasize} \n" ;
    }
}