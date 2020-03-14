using System;
using System.Collections.Generic;
using System.Text;

namespace code_challenge.menuoption
{
    class SumRows
    {
        public static void SumOfRows(string name)
        {
            int lengthNumber;
            int widthNum;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine($"{name}, please type in length of the array");
            Console.ForegroundColor = ConsoleColor.White;
            bool checkLengthNumber = Int32.TryParse(Console.ReadLine(), out lengthNumber);
            while (!checkLengthNumber)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please type in number !!!");
                Console.ForegroundColor = ConsoleColor.White;
                checkLengthNumber = Int32.TryParse(Console.ReadLine(), out lengthNumber);
            }
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{name}, please type in width of the array");
            Console.ForegroundColor = ConsoleColor.White;
            bool checkWidthNumber = Int32.TryParse(Console.ReadLine(), out widthNum);
            while (!checkWidthNumber)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter integer!");
                Console.ForegroundColor = ConsoleColor.White;
                checkWidthNumber = Int32.TryParse(Console.ReadLine(), out widthNum);
            }
            Console.Beep();
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Press any key to generate random numbers");
            Console.ResetColor();
            Console.ReadLine();
            Random randomNum = new Random();
            int[,] myArray = new int[lengthNumber, widthNum];
            int[] sumArray = new int[lengthNumber];
            for (int i = 0; i < lengthNumber; i++)
            {
                int count = 0;
                for (int j = 0; j < widthNum; j++)
                {
                    int generatedNumber = randomNum.Next(1, 10);
                    myArray[i, j] = generatedNumber;
                    count += generatedNumber;
                    Console.WriteLine("[{0}, {1}] = {2}", i, j, myArray[i, j]);
                }
                sumArray[i] = count;
            }
            Console.WriteLine("The sum of each row was, [{0}]", String.Join(", ", sumArray));
        }
    }
}
