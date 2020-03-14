using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * int x;
             int y;/// asking the run time to craete memory for these two varibles

             x = 7;
             y = x + 3;

             Console.WriteLine(y);
             Console.ReadLine();
             */

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: "); /// write out the statement and double quotes and wait
            string myFirstName;
            myFirstName = Console.ReadLine();

            /*   String myLastName;
               Console.Write("Type your last Name: ");
               myLastName = Console.ReadLine(); */

            Console.WriteLine("type your last name: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, {0} {1}.", myFirstName, myLastName); //Concatenating everything.
            Console.ReadLine();
        }
    }
}
