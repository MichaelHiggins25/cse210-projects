using System;

class Program
{
    private static string _userchoice;
    private static string _userentry1 = "na";
    private static string _userentry2 = "na";
    private static string _userentry3 = "na";
    private static string _userentry4 = "na";
    private static string _userentry5 = "na";
    private static int _userentry6 = 0;
    private static int _userentry7 = 0;
    private static int _userentry8 = 0;
    private static int _userentry9 = 0;
    private static bool _running = true;
    static void Main(string[] args)
    {
        World world1 = new World();
        do
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
            "5. Exit" +
            "Please chose a part of your world to build ... "
            ); 
            _userchoice = Console.ReadLine();
            }

            switch (_userchoice)
            {
                case "1":
                    while (_userentry1 != "") 
                    {
                        Console.WriteLine("");
                        _userentry1 = Console.ReadLine();
                        Areas area1 = new Areas(_userentry1, _userentry6, _userentry7, _userentry8, _userentry9);
                    }
                    break;

                case "2":
                    Console.WriteLine("");
                    _userentry1 = Console.ReadLine();
                    States states1 = new States(_userentry1, _userentry2, _userentry6);
                    break;

                case "3":
                    Console.WriteLine("");
                    _userentry1 = Console.ReadLine();
                    Organizations organization1 = new Organizations(_userentry1, _userentry2, _userentry6);
                    break;

                case "4":
                    Console.WriteLine("");
                    _userentry1 = Console.ReadLine();
                    Characters characters1 = new Characters(_userentry1, _userentry2, _userentry6, _userentry7, _userentry3, _userentry4, _userentry5);
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    _running = false;
                    return;
            }
        } while (_running == true);
    }
    private Program(string userentry1, string userentry2, string userentry3, string userentry4, string userentry5, int userentry6, int userentry7, int userentry8, int userentry9, int userentry10) //gets the users answer to ?s
    {
        _userentry1 = userentry1;
        _userentry2 = userentry2;
        _userentry3 = userentry3;
        _userentry4 = userentry4;
        _userentry5 = userentry5;
        _userentry6 = userentry6;
        _userentry7 = userentry7;
        _userentry8 = userentry8;
        _userentry9 = userentry9;
    }
}