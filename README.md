
The answer to your [question](https://stackoverflow.com/q/74827932/5438626) is _yes_ you can convert an `int` to an `Enum`:

    // Works. But is it ideal for the code you posted?
    Enum someEnum = (Enum)Enum.ToObject(typeof(ConsoleKey), 49);

The value of `someEnum` is now `ConsoleKey.D1`.
***

You can also convert an `int` to an `enum` (lower case):


    ConsoleKey key = (ConsoleKey)49;

The value of `key` is now `ConsoleKey.D1`.
***

You can also do this in reverse which is `(int)ConsoleKey.D1` to get a value of 49.
***

**However** let's look at your code which shows a call to `ReadKey`. The type returned from this method is a `ConsoleKeyInfo` whose job is to give you all the information you need about the key that was pressed. 

Just because you _can_ convert between the two types doesn't mean that you _should_. You have choices!

One good way to take advantage of the format that it returns is to switch on the value of `Key` to perform the action you want. This example is a menu-driven game and the menu is looking for a key between 1 and 5. 

***
The `ConsoleKey.Key` value for the '1' key is `ConsoleKey.D1` (and so on...).

    static void Main(string[] args)
    {
        // Loop until a valid int is received.
        bool exit = false;
        while (!exit)
        {
            displayMenu();

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
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
Every loop iteration displays a menu:


[![console][1]][1]

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



  [1]: https://i.stack.imgur.com/NFfCW.png