using System;
using System.Collections.Generic;
using System.Text;

namespace code_challenge.menuoption
{
    class Menu
    {
        public static bool Mainmenu(string name)
        {
            if (name == "")
                throw new ArgumentException("no name");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine($"- Hello {name}, choose an option of application -");
            Console.WriteLine("#             1. Array Max Result            #");
            Console.WriteLine("#           2. Leap Year Calculator          #");
            Console.WriteLine("#            3. Perfect Sequence             #");
            Console.WriteLine("#               4. Sum of Rows               #");
            Console.WriteLine("#                  5. EXIT                   #");
            int userChoice;
            bool numberCheck = Int32.TryParse(Console.ReadLine(), out userChoice);
            while (!numberCheck)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a number");
                Console.ForegroundColor = ConsoleColor.White;
                numberCheck = Int32.TryParse(Console.ReadLine(), out userChoice);
            }
            if (userChoice == 1)
            {
                ArrayMax.ArrayMaxResult(name);
                return true;
            }
            else if (userChoice == 2)
            {
                LeapYear.LeapYearCalc(name);
                return true;
            }
            else if (userChoice == 3)
            {
                PerfSequence.PerfectSequence(name);
                return true;
            }
            else if (userChoice == 4)
            {
                SumRows.SumOfRows(name);
                return true;
            }
            else if (userChoice == 5)
            {
                return false;
            }
            else
            {
                throw new ArgumentNullException("not a number choice");
            }
        }
    }
}
