class Characters
{
    public List<string> charactersl = new List<string>();
    private string _name;
    private string _backgroundDetails;
    private string _sex;
    private int _hight;
    private int _weight;
    private string _hairColor;
    private string _bodyBuild;
    private string _relations;
    
    public Characters()
    {
        _name = "";
        _backgroundDetails = "";
        _sex = "na";
        _hight = 0;        
        _weight = 0;
        _hairColor = "na";
        _bodyBuild = "na";
        _relations = "na";
    }
    public Characters(string name,string backgroundDetails,string sex,int hight, int weight,string hairColor,string bodyBuild,string relations)
    {
        _name = name;
        _backgroundDetails = backgroundDetails;
        _sex = sex;
        _hight = hight;        
        _weight = weight;
        _hairColor = hairColor;
        _bodyBuild = bodyBuild;
        _relations = relations;
    }

    public Characters(string name,string backgroundDetails,string sex, string hairColor,string bodyBuild,string relations)
    {
        _name = name;
        _backgroundDetails = backgroundDetails;
        _sex = sex;
        _hight = 0;        
        _weight = 0;
        _hairColor = hairColor;
        _bodyBuild = bodyBuild;
        _relations = relations;
    }
        public Characters(string name,string backgroundDetails, int hight, int weight, string hairColor,string bodyBuild,string relations)
    {
        _name = name;
        _backgroundDetails = backgroundDetails;
        _sex = "na";
        _hight = hight;        
        _weight = weight;
        _hairColor = hairColor;
        _bodyBuild = bodyBuild;
        _relations = relations;
    }
    public string GetCharacters()
    {
        return $"Here is the info of all of your Characters \n" +
        $"Name: {_name} \n" +
        $"Background: {_backgroundDetails} \n" + 
        $"Relations: {_relations} \n" + 
        $"Sex: {_sex} \n" + 
        $"Hight: {_hight} \n" + 
        $"Weight: {_weight} \n" + 
        $"Hair Color: {_hairColor} \n" +
        $"Body Build: {_bodyBuild} \n";
    }
}