using System;

namespace code_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();
            bool userChoice = true;
            while (userChoice) 
            {
                userChoice = Mainmenu(userName);
            }
            Console.WriteLine($"Thank you for playing bye~ {userName}");
            Console.ReadLine();

        }

        private static bool Mainmenu(string name)
        {
            Console.WriteLine($"Hello {name}, choose an option of application");
            Console.WriteLine("1. Array Max Result");
            Console.WriteLine("2. Leap Year Calculator");
            Console.WriteLine("3. Perfect Sequence");
            Console.WriteLine("4. Sum of Rows");
            Console.WriteLine("5. EXIT");
            int userChoice = int.Parse(Console.ReadLine());
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
            int[] choiceArray = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{name}, choose five numbers between 1-10({i + 1}/5)");
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
                "{1}, your choices were: {0}.",
                String.Join(", ", choiceArray), name);
            Console.WriteLine(
                "My choice was {0}, and overall you got {1}.",
                4, myScore);
        }
        private static void LeapYearCalc(string name)
        {
            Console.WriteLine("Enter a year");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("Congratulation {0}, it is leap year", name);
            }
            else if (year % 4 == 0 && year % 400 == 0)
            {
                Console.WriteLine("Congratulation {0}, it is leap year", name);
            }
            else
            {
                Console.WriteLine("Sorry {0}, It is not leap year", name);
            }
        }

        private static void PerfectSequence(string name)
        {
            Console.WriteLine("Type in numbers of choice with comma inbetween each number of numbers to check if its perfect sequence");
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
