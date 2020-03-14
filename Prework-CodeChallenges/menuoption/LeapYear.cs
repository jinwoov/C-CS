using System;
using System.Collections.Generic;
using System.Text;

namespace code_challenge.menuoption
{
    class LeapYear
    {
        public static void LeapYearCalc(string name)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine("Enter a year to check for leap year");
            Console.ForegroundColor = ConsoleColor.White;
            int year;
            bool checkNumb = Int32.TryParse(Console.ReadLine(), out year);
            while (!checkNumb)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a year in numerical value _-_;");
                Console.ForegroundColor = ConsoleColor.White;
                checkNumb = Int32.TryParse(Console.ReadLine(), out year);
            }
            if (year % 4 == 0 && year % 100 != 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine("Yes! {0}, {1} is leap year", name, year);
                Console.ResetColor();
            }
            else if (year % 4 == 0 && year % 400 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine("Yes! {0}, {1} is leap year", name, year);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("T.T Sorry {0}, {1} is not leap year", name, year);
                Console.ResetColor();
            }
        }
    }
}
