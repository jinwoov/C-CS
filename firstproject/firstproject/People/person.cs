using System;
using System.Collections.Generic;
using System.Text;


namespace firstproject.People
{
    public class Person
    {
        public string Name;
        public int Age;
        public bool HasPet;

        public void Greeting()
        {
            Console.WriteLine("Hi my name is " + Name + " and my age is " + Age);
        }
    }
}
