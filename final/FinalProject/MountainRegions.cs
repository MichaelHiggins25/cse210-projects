class MountainRegions: Areas
{
    public int _rangesHeightTo; // lowest mountain
    public int _rangesHeightFrom; // tallest mountain
    public List<string> wregion = new List<string>();
    public MountainRegions(string name, string description, int rangesHeightTo, int rangesHeightFrom)
    {
        _namea = name;
        _description = description;
        _rangesHeightTo = rangesHeightTo;
        _rangesHeightFrom = rangesHeightFrom;
    }

    public MountainRegions (string name, int rangesHeightTo, int rangesHeightFrom)
        : base (_namea)
    {
        _namea = name;
        _description = "na";
        _rangesHeightTo = rangesHeightTo;
        _rangesHeightFrom = rangesHeightFrom;
    }
    public string GetMountainRegion()
    {
        return $"Here is the info of all your land regions. \n" + 
        $"Name: {_namea} \n" +
        $"Description: {_description} \n" +
        $"The mountain ranges height is from {_rangesHeightFrom} to {_rangesHeightTo} \n" ;
    }
}