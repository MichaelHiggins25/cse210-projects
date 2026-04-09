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
    private static bool _running = true;
    static void Main(string[] args)
    {
        World world1 = new World();
        do //Beeeeg loop!
        {
        if (_userchoice != "5")
        { 
            Console.WriteLine("Hello and welcome to The World Building Sandbox \n" + 
            "1. Areas" +
            "2. States" +
            "3. Organizations" +
            "4. Characters" +
            "5. Exit" +
            "A new world has been made." +
            "Please chose a part of your world to build ... "
            );
        }
        else
        {
            Console.WriteLine("Hello and welcome to The World Building Sandbox \n" + 
            "1. Areas" +
            "2. States" +
            "3. Organizations" +
            "4. Characters" +
            "5. Show all info on the world" +
            "5. Exit" +
            "Please chose a part of your world to build ... "
            ); 
            _userchoice = Console.ReadLine();
        }

        switch (_userchoice)
        {
            case "1": // Makes an Areas object or Region objects.
                while (_userentry1 != "") 
                {
                    Console.Write("Ok. First enter the name of the area.");
                    _userentry1 = Console.ReadLine();
                    Console.WriteLine("Then enter in the description of the area.");
                    _userentry2 = Console.ReadLine();
                    Console.WriteLine("Then enter in the idexing number and your done.");
                    _userentry9 =  int.Parse(Console.ReadLine());
                    Areas area1 = new Areas(_userentry1, _userentry2, _userentry6, _userentry7, _userentry8, _userentry9);
                } // ints in this object are just stand-ins (except #9). The math is done in the method thats in their class.
                break;

            case "2": //Makes a States object.
                Console.WriteLine("Ok. First enter the name of the state.");
                _userentry1 = Console.ReadLine();
                Console.WriteLine("Then enter in the description of the area.");
                    _userentry2 = Console.ReadLine();
                Console.WriteLine("Then enter in the idexing number and your done.");
                    _userentry6 = int.Parse(Console.ReadLine());
                States states1 = new States(_userentry1, _userentry2, _userentry6);
                break;

            case "3": // Makes an Organization object.
                Console.WriteLine("Ok. First enter the name of the organization.");
                _userentry1 = Console.ReadLine();
                Console.WriteLine("Then enter in the description of the area.");
                    _userentry2 = Console.ReadLine();
                Console.WriteLine("Then enter in the idexing number and your done.");
                    _userentry6 = int.Parse(Console.ReadLine());
                Organizations organization1 = new Organizations(_userentry1, _userentry2, _userentry6);
                break;

            case "4": // Make a Character object.
                Console.WriteLine("Ok. First enter the name of your person.");
                _userentry1 = Console.ReadLine();
                Console.WriteLine("");
                _userentry2 = Console.ReadLine();
                Console.WriteLine("");
                _userentry6 = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                _userentry7 = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                _userentry3 = Console.ReadLine();
                Console.WriteLine("");
                _userentry4 = Console.ReadLine();
                Console.WriteLine("");
                _userentry5 = Console.ReadLine();
                Characters characters1 = new Characters(_userentry1, _userentry2, _userentry6, _userentry7, _userentry3, _userentry4, _userentry5);
                break;

            case "5": // Will show all info from each class.
                Console.Write(world1);
                break;

            case "6": // Exits the whole program.
                Environment.Exit(0);
                break;

            default: // Exits this loop.
                _running = false;
                return;
            }
        } while (_running == true); // Beeeeg loop!
    }
}