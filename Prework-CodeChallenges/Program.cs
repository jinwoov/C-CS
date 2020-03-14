using System;
using code_challenge.menuoption;

namespace code_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine(@"
                                ================================
                                #   Welcome to my application  #
                                #      made by Jin             #
                                ================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("What's your name?");
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.White;
            string userName = Console.ReadLine();
            bool userChoice = true;
            while (userChoice)
            {
                userChoice = Menu.Mainmenu(userName);
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Thank you for playing bye~ {userName}");
            Console.ResetColor();
            Environment.Exit(0);
            }
            catch (Exception)
            {
                Console.WriteLine("You have entered invalid entry, please restrt the application");
            }
        }
    }
}