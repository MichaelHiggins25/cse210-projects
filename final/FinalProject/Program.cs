using System;

class Program
{
    private static string _userchoice;
    private static string _userentry1;
    private static string _userentry2;
    private static string _userentry3;
    private static string _userentry4;
    private static string _userentry5;
    private static int _userentry6;
    private static int _userentry7;
    private static int _userentry8;
    private static int _userentry9;
    private static int _userentry10 = 0;
    private static bool _running = true;
    private static string _stop = "yes";
    public static List <string> printer = new List<string>();
    static void Main(string[] args)
    {
        World world1 = new World();
        List<World> worlds = new List<World>();
        worlds.Add(world1);
        States states = new States();
        Areas areas = new Areas();
        LandRegions lands = new LandRegions();
        WaterRegions waters = new WaterRegions();
        MountainRegions mountains = new MountainRegions();
        Characters characters = new Characters();
        Organizations organizations = new Organizations();

        Console.Clear();
        while (_running == true)  //Beeeeg loop!
        {
            
            Console.WriteLine("Hello and welcome to The World Building Sandbox \n" +
            "1. Areas \n" +
            "2. States \n" +
            "3. Organizations \n" +
            "4. Characters \n" +
            "5. Show all info on the world \n" +
            "6. Exit \n" +
            "Please chose a part of your world to build ..."
            );
            _userchoice = Console.ReadLine();
            _stop = "yes";
            Console.Clear();

            switch (_userchoice)
            {
                case "1":
                    // Makes an Areas object or Region objects.
                    Console.WriteLine("Would you like to make an area or a region with in an area? (area/region)");
                    _userchoice = Console.ReadLine();
                    if (_userchoice == "area")
                    {
                        while (_stop == "yes")
                        {
                            Console.WriteLine("Ok. First enter the name of the area.");
                            _userentry1 = Console.ReadLine();
                            Console.WriteLine("Then enter in the description of the area.");
                            _userentry2 = Console.ReadLine();
                            Console.WriteLine("Then enter in the idexing number and your done.");
                            _userentry9 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Your area has been put into place on your world.");
                            Areas areas1 = new Areas(_userentry1, _userentry2, _userentry6, _userentry7, _userentry8, _userentry9, _userentry10);
                            areas.areasl.Add($"{areas1}");
                            Console.WriteLine("Would you like to continue making areas? (yes/no) ");
                            _stop = Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else if (_userchoice == "region")
                    {
                        Console.WriteLine("What kind of region would you like? (grass/water/mountains)");
                        _userchoice = Console.ReadLine();
                        switch (_userchoice)
                            {
                            case "grass":
                            Console.WriteLine("Ok. First enter the name of the area.");
                            _userentry1 = Console.ReadLine();
                            Console.WriteLine("Then enter in the description of the region.");
                            _userentry2 = Console.ReadLine();
                            Console.WriteLine("Then enter in the size of the region (in m/sqft) and your done.");
                            _userentry6 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Your area has been put into place on your world.");
                            LandRegions region1 = new LandRegions(_userentry1, _userentry2, _userentry6);
                            areas.regionsl.Add($"{region1}");
                            break;

                            case "water":
                            Console.WriteLine("Ok. First enter the name of the area.");
                            _userentry1 = Console.ReadLine();
                            Console.WriteLine("Then enter in the description of the region.");
                            _userentry2 = Console.ReadLine();
                            Console.WriteLine("Then enter the number of rivers off shotting streams (if there are any).");
                            _userentry6 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Then enter in the size of the region (in m/sqft) and your done.");
                            _userentry7 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Your area has been put into place on your world.");
                            WaterRegions region2 = new WaterRegions(_userentry1, _userentry2, _userentry6, _userentry7);
                            areas.regionsl.Add($"{region2}");
                            break;

                            case "mountains":
                            Console.WriteLine("Ok. First enter the name of the area.");
                            _userentry1 = Console.ReadLine();
                            Console.WriteLine("Then enter in the description of the region.");
                            _userentry2 = Console.ReadLine();
                            Console.WriteLine("");
                            _userentry7 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Then enter in the size of the region (in m/sqft) and your done.");
                            _userentry8 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Your area has been put into place on your world.");
                            MountainRegions region3 = new MountainRegions(_userentry1, _userentry2, _userentry7, _userentry8);
                            areas.regionsl.Add($"{region3}");
                            break;
                            }
                    }
                    break;
                case "2": //Makes a States object.
                    while (_stop == "yes")
                    {
                        Console.WriteLine("Ok. First enter the name of the state.");
                        _userentry1 = Console.ReadLine();
                        Console.WriteLine("Then enter in the description of the state.");
                        _userentry2 = Console.ReadLine();
                        Console.WriteLine("Then enter in the idexing number and your done.");
                        _userentry6 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Your state has been put into place on your world");
                        States states1 = new States(_userentry1, _userentry2, _userentry6);
                        Console.WriteLine("Would you like to continue making states? (yes/no)");
                        states.statesl.Add($"{states1}");
                        _stop = Console.ReadLine();
                    }
                    break;

                case "3": // Makes an Organization object.
                    while (_stop == "yes")
                    {
                        Console.WriteLine("Ok. First enter the name of the organization.");
                        _userentry1 = Console.ReadLine();
                        Console.WriteLine("Then enter in the description of the organization.");
                        _userentry2 = Console.ReadLine();
                        Console.WriteLine("Then enter in the idexing number and your done.");
                        _userentry6 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Your organiztion has been placed into your world.");
                        Organizations organization1 = new Organizations(_userentry1, _userentry2, _userentry6);
                        Console.WriteLine("Would you like to continue making organizations? (yes/no) ");
                        organizations.organizationsl.Add($"{organization1}");
                        _stop = Console.ReadLine();
                        Console.Clear();
                    }
                    break;

                case "4": // Make a Character object.
                    while (_stop == "yes")
                    {
                        Console.WriteLine("Ok. First enter the name of your person.");
                        _userentry1 = Console.ReadLine();
                        Console.WriteLine("Then enter in backstory for this person.");
                        _userentry2 = Console.ReadLine();
                        Console.WriteLine("Then enter in their height.");
                        _userentry6 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Then enter in their weight");
                        _userentry7 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Then enter in their hair color.");
                        _userentry3 = Console.ReadLine();
                        Console.WriteLine("Then enter in their body type.");
                        _userentry4 = Console.ReadLine();
                        Console.WriteLine("Then, finaly, enter in any relationship they have with others.");
                        _userentry5 = Console.ReadLine();
                        Console.WriteLine("Your character has been placed into your world.");
                        Characters characters1 = new Characters(_userentry1, _userentry2, _userentry6, _userentry7, _userentry3, _userentry4, _userentry5);
                        Console.WriteLine("Would you like to continue making characters? (yes/no)");
                        characters.charactersl.Add($"{characters1}");
                        _stop = Console.ReadLine();
                        Console.Clear();
                    }
                    break;

                case "5": // Will show all info from each class.
                    Console.WriteLine("Here all the info on your world.");
                    world1.GetLists(states.statesl,characters.charactersl,organizations.organizationsl,areas.areasl,areas.regionsl);
                    Console.WriteLine("When your ready to continue, press any key.");
                    Console.ReadKey();
                    break;

                case "6": // Exits the whole program.
                          //Environment.Exit(0);
                    break;

                default: // Exits this loop.
                    _running = false;
                    return;
            }
        }
        ;
    }
}