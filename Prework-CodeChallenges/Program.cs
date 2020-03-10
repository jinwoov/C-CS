using System;

namespace code_challenge
{
    class Program
    {
        static void Main(string[] args)
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
                userChoice = Mainmenu(userName);
            }
            Console.WriteLine($"Thank you for playing bye~ {userName}");
            Environment.Exit(0);

        }

        private static bool Mainmenu(string name)
        {
            Console.WriteLine("");
            Console.WriteLine($"Hello {name}, choose an option of application");
            Console.WriteLine("1. Array Max Result");
            Console.WriteLine("2. Leap Year Calculator");
            Console.WriteLine("3. Perfect Sequence");
            Console.WriteLine("4. Sum of Rows");
            Console.WriteLine("5. EXIT");
            int userChoice;
            bool numberCheck = Int32.TryParse(Console.ReadLine(), out userChoice);
            while(!numberCheck)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a number");
                Console.ForegroundColor = ConsoleColor.White;
                numberCheck = Int32.TryParse(Console.ReadLine(), out userChoice);
            }
            if (userChoice == 1)
            {
                ArrayMaxResult(name);
                return true;
            }
            else if (userChoice == 2)
            {
                LeapYearCalc(name);
                return true;
            }
            else if (userChoice == 3)
            {
                PerfectSequence(name);
                return true;
            }
            else if (userChoice == 4)
            {
                SumOfRows(name);
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void ArrayMaxResult(string name)
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            int[] choiceArray = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{name}, choose five numbers between 1-10({i + 1}/5)");
                bool checkNumb = Int32.TryParse(Console.ReadLine(), out choiceArray[i]);
                while(!checkNumb)
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
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(
                "********* Congratulation! My choice was {0}, and overall you got {1} points. ***********", 4, myScore);
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        private static void LeapYearCalc(string name)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine("Enter a year to check for leap year");
            Console.ForegroundColor = ConsoleColor.White;
            int year; 
            bool checkNumb = Int32.TryParse(Console.ReadLine(), out year);
            while(!checkNumb)
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (year % 4 == 0 && year % 400 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine("Yes! {0}, {1} is leap year", name, year);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.WriteLine("T.T Sorry {0}, {1} is not leap year", name, year);
            }
        }

        private static void PerfectSequence(string name)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine("Type in numbers of choice with comma in-between each number of numbers to check if its perfect sequence");
            Console.ForegroundColor = ConsoleColor.White;
            string userInput = Console.ReadLine();
            string[] newArray = userInput.Split(",");
            int[] numArray = Array.ConvertAll(
                newArray, str => int.Parse(str));
            int count = 0;
            int countMult = 1;
            foreach (var value in numArray)
            {
                if (value<0) {
                    Console.WriteLine("{2}, you entered {0} and you've entered negative value of {1}", userInput, value, name);
                    Console.WriteLine("No, it is not a perfect sqeuence.");
                    return;
                }
                else {
                    count += value;
                    countMult *= value;
                }
            }
            if (count == countMult){
                Console.WriteLine("{1}, you entered {0}",userInput, name);
                Console.WriteLine("Yes, it is perfect sequence!");
            }
            else {
            Console.WriteLine("{1}, you entered {0}",userInput, name);
            Console.WriteLine("No, it is not a perfect sqeuence.");
            }
        }
        private static void SumOfRows(string name)
        {   
            Console.WriteLine($"{name}, please type in length of the array");
            int lengthNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"{name}, please type in width of the array");
            int widthNum = int.Parse(Console.ReadLine());

            Random randomNum = new Random();
            int [,] myArray = new int[lengthNumber, widthNum];
            int[] sumArray = new int[lengthNumber];
            for(int i=0; i < lengthNumber; i++)
            {
                int count = 0;    
                for(int j=0; j<widthNum; j++) 
                {
                    int generatedNumber = randomNum.Next(1,10);
                    myArray[i, j] = generatedNumber;
                    count += generatedNumber;
                    Console.WriteLine("[{0}, {1}] = {2}", i, j, myArray[i,j]);
                }
                sumArray[i] = count;
            }
            Console.WriteLine("The sum of each row was, [{0}]", String.Join(", ", sumArray));
        }
    }
}
