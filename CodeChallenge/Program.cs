using System;

namespace code_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userChoice = true;
            while (userChoice)
                userChoice = Mainmenu();

        }

        private static bool Mainmenu()
        {
            Console.WriteLine("Choose an option of application");
            Console.WriteLine("1. Array Max Result");
            Console.WriteLine("2. Leap Year Calculator");
            Console.WriteLine("3. Perfect Sequence");
            Console.WriteLine("4. EXIT");
            int userChoice = int.Parse(Console.ReadLine());
            if (userChoice == 1)
            {
                ArrayMaxResult();
                return true;
            }
            else if (userChoice == 2)
            {
                LeapYearCalc();
                return true;
            }
            else if (userChoice == 3)
            {
                PerfectSequence();
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void ArrayMaxResult()
        {
            int[] choiceArray = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Choose five numbers between 1-10({i + 1}/5)");
                choiceArray[i] = int.Parse(Console.ReadLine());
            }
            int myScore = 4;
            int counter = 0;
            foreach (var numbers in choiceArray)
            {
                if (numbers == myScore)
                    counter++;
            }
            myScore *= counter;
            Console.WriteLine(
                "Your choices were: {0}.",
                String.Join(", ", choiceArray));
            Console.WriteLine(
                "My choice was {0}, and overall you got {1}.",
                4, myScore);
        }
        private static void LeapYearCalc()
        {
            Console.WriteLine("Enter a year");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("it is leap year");
            }
            else if (year % 4 == 0 && year % 400 == 0)
            {
                Console.WriteLine("it is leap year");
            }
            else
            {
                Console.WriteLine("It is not leap year");
            }
        }

        private static void PerfectSequence()
        {
            Console.WriteLine("Type in array of numbers to check if its perfect sequence");
            string userInput = Console.ReadLine();
            userInput = userInput.Replace("[", "");
            userInput = userInput.Replace("]", "");
            string[] newArray = userInput.Split(",");
            int[] numArray = Array.ConvertAll(
                newArray, str => int.Parse(str));
            int count = 0;
            int countMult = 1;
            foreach (var value in numArray)
            {
                if (value<0) {
                    Console.WriteLine("You entered negative number");
                    Console.WriteLine("No");
                    return;
                }
                else {
                    count += value;
                    countMult *= value;
                }
            }
            if (count == countMult){
                Console.WriteLine("Yes");
            }
            else {
                Console.WriteLine("No");
            }
        }
    }
}
