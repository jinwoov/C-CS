using System;
using System.Collections.Generic;
using System.Text;

namespace code_challenge.menuoption
{
    class ArrayMax
    {
        public static void ArrayMaxResult(string name)
        {
            Console.WriteLine("");
            int[] choiceArray = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{name}, choose five numbers between 1-10({i + 1}/5)");
                Console.ForegroundColor = ConsoleColor.Yellow;
                bool checkNumb = Int32.TryParse(Console.ReadLine(), out choiceArray[i]);
                while (!checkNumb)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("please type in number! -_-^");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    checkNumb = Int32.TryParse(Console.ReadLine(), out choiceArray[i]);
                }
            }
            Console.Beep();
            int myScore = 4;
            int counter = 0;
            foreach (var numbers in choiceArray)
            {
                if (numbers == myScore)
                    counter++;
            }
            myScore *= counter;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
                "{1}, your choices were: {0}.",
                String.Join(", ", choiceArray), name);
            if (myScore <= 8)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(
                "My choice was {0}, and overall you got {1} points.", 4, myScore);
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(
                "********* Congratulation! My choice was {0}, and overall you got {1} points. ***********", 4, myScore);
                Console.ResetColor();
            }
        }
    }
}
