class Characters
{
    public List<string> characters = new List<string>();
    private string _name;
    private string _backgroundDetails;
    private string _sex;
    private int _hight;
    private int _weight;
    private string _hairColor;
    private string _bodyBuild;
    private string _relations;
    public void CreateCharacters(string name,string backgroundDetails,string sex,int hight, int weight,string hairColor,string bodyBuild,string relations)
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
}