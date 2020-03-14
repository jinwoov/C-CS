using System;
using System.Collections.Generic;
using System.Text;

namespace code_challenge.menuoption
{
    class PerfSequence
    {
        public static void PerfectSequence(string name)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine("Type in numbers of choice with comma in-between each number of numbers to check if its perfect sequence");
            Console.ForegroundColor = ConsoleColor.White;
            string userInput = Console.ReadLine();
            bool checkComma = userInput.Contains(",");
            while (!checkComma)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please include comma ^-_-;");
                Console.ForegroundColor = ConsoleColor.White;
                userInput = Console.ReadLine();
                checkComma = userInput.Contains(",");
            }
            Console.Beep();
            string[] newArray = userInput.Split(",");
            int[] numArray = Array.ConvertAll(
                newArray, str => int.Parse(str));
            int count = 0;
            int countMult = 1;
            foreach (var value in numArray)
            {
                if (value < 0)
                {
                    Console.WriteLine("{2}, you entered {0} and you've entered negative value of {1}", userInput, value, name);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No, it is not a perfect sqeuence.");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                else
                {
                    count += value;
                    countMult *= value;
                }
            }
            if (count == countMult)
            {
                Console.Beep();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("{1}, you entered {0}", userInput, name);
                Console.WriteLine("Yes, it is perfect sequence!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("{1}, you entered {0}", userInput, name);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No, it is not a perfect sqeuence.");
                Console.ResetColor();
            }
        }
    }
}
