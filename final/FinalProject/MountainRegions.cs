class MontainRegions: Areas
{
    private string _rangesHeightTo; //lowest mountain
    private string _rangesHeightFrom; // tallest mountain
    public MontainRegions(string name, string description, int rangesHeightTo, int rangesHeightFrom) : base(name,description)
    {
        _namea = name;
        _description = description;
    }

    public string GetMountainRegion()
    {
        return $"Here is the info of all your land regions. \n" + 
        $"Name: {_namea} \n" +
        $"Description: {_description} \n" +
        $"The mountain ranges height is from {_rangesHeightFrom} to {_rangesHeightTo} \n" ;
    }
}