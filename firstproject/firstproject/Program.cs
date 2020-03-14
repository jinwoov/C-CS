using System;
using firstproject.People;
using firstproject.Calc;

namespace firstproject
{

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Jin";
            person.Age = 31;
            person.HasPet = true;

            person.Greeting();
        }
        static void Main1(string[] args)
        {
            int result = Calculator.Add(5, 10);
            Console.WriteLine(result);
        }

    }
}

