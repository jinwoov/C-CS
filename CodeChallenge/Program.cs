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
           if (userChoice == 1) {
               ArrayMaxResult();
               return true;
           }
           else {
               return false;
           }
        }
        private static void ArrayMaxResult()
        {
            int[] choiceArray = new int[5];
            for (int i = 0; i < 5; i++)
            {
            Console.WriteLine($"Choose five numbers between 1-10({i+1}/5)");
            choiceArray[i]= int.Parse(Console.ReadLine());
            }
            int myScore = 4;
            int counter = 0;
            foreach (var numbers in choiceArray)
            {
                if (numbers == myScore)
                counter++;
            }
            myScore *=counter;
            Console.WriteLine(
                "Your choices were: {0}.", 
                String.Join(", ", choiceArray));
            Console.WriteLine(
                "My choice was {0}, and overall you got {1}.",
                4, myScore);
        }
    }
}
