Your post shows a call to `ReadKey`. The type returned from this method is a `ConsoleKeyInfo` whose job is to tell you everything you want to know about the key that was pressed. So just because you _can_ cast it to an `int` doesn't mean that you _should_. One good way to take advantage of the format that it returns is to switch on the value of `Key` to perform the action you want. This example is a menu-driven game and the menu is looking for a key between 1 and 5:

    static void Main(string[] args)
    {
        // Loop until a valid int is received.
        bool exit = false;
        while (!exit)
        {
            displayMenu();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1: setup(); break;
                case ConsoleKey.D2: createCharacter(); break;
                case ConsoleKey.D3: changeAvatar(); break;
                case ConsoleKey.D4: editProfile(); break;
                case ConsoleKey.D5: play(); break;
                case ConsoleKey.Escape: exit = true; break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please enter a number 1-5");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }

***
First it displays a menu:

    private static void displayMenu()
    {
        Console.Clear();
        Console.WriteLine("1 - Setup");
        Console.WriteLine("2 - Create Character");
        Console.WriteLine("3 - Change Avatar");
        Console.WriteLine("4 - Edit Profile");
        Console.WriteLine("5 - Play");
        Console.WriteLine();
        Console.WriteLine("Escape key to Exit");
    }

***
And based on the value of `ReadKey` it will exec one of the five actions _or_ it will exit the game.

    private static void setup() { }
    private static void createCharacter() { }
    private static void changeAvatar() { }
    private static void editProfile() { }
    private static void play() { }


