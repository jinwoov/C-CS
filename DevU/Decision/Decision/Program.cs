using System;

namespace Decision
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Jin's Big Giveaway");
            Console.Write("Choose a door: 1 ,2 or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                 message = "you won a new car!";
            else if (userValue == "2")
                 message = "you won a boat";
            else if (userValue == "3")
                 message = "you won a cat";
            else
            { 
                 message = "Sorry we didn't understand.";
                message += "you lose";
            }

            Console.WriteLine(message);
            Console.ReadLine();

      */

            Console.WriteLine("Jin's Big Giveaway");
            Console.Write("Choose a door: 1 ,2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";

            /* Console.Write("you won a ");
             Console.Write(message);
             Console.Write("."); */

           // Console.WriteLine("You won a {0}.", message);
            Console.WriteLine("You entered:{0}, therefore you won a {1}.", userValue, message);

            Console.ReadLine();
        }
    }
}
