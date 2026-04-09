using System;

class Program
{
    private static string _userchoice;
    private static string userentry1 = "na";
    private static string userentry2 = "na";
    private static string userentry3 = "na";
    private static string userentry4 = "na";
    private static string userentry5 = "na";
    private static int userentry6 = 0;
    private static int userentry7 = 0;
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
                    while (userentry1 != "") 
                    {
                        Console.WriteLine("");
                        userentry1 = Console.ReadLine();
                        Areas area1 = new Areas(0);
                    }
                    break;

                case "2":
                    Console.WriteLine("");
                    userentry1 = Console.ReadLine();
                    States states1 = new States($"{userentry1}",$"{userentry2}", 0);
                    break;

                case "3":
                    Console.WriteLine("");
                    userentry1 = Console.ReadLine();
                    Organizations organization1 = new Organizations("");
                    break;

                case "4":
                    Console.WriteLine("");
                    userentry1 = Console.ReadLine();
                    Characters characters1 = new Characters();
                    break;

                case "5":
                    break;

                default:
                    break;
            }
        } while (_running == true);
    }
}