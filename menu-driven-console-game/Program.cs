using System;
using System.Threading;

namespace menu_driven_console_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Menu-Driven Game";
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

        private static void setup() { }
        private static void createCharacter() { }
        private static void changeAvatar() { }
        private static void editProfile() { }
        private static void play() { }
    }
}
