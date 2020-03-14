using System;

namespace whileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            displayMenu = MainMenu();
       
        }


        private static bool MainMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Print Number");
            Console.WriteLine("2) Guessing Number ");
            Console.WriteLine("3) exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumber();
                return true;

            }
            else if (result == "2")
            {
                GuessingGame();
                return true;

            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static void PrintNumber()
        {
            Console.Clear();
            Console.WriteLine("Print numbers");
            Console.Write("type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game!");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();
                guesses++;

                if (result == randomNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Wrong!");

            } while (incorrect);
            Console.WriteLine(" Horray you got it, it took you {0} guesses", guesses);

            Console.ReadLine();

        }
    
    }



}
