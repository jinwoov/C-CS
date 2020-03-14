- longer number is int 36
- to parse the string into a number you put `Int32.Parse(num)`
- num = Console.Readline user has to input something
```
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string num = Console.ReadLine();
            int num2 = Int32.Parse(num);
            int newAge = num2 + 5;

            Console.WriteLine("Your age in 5 years is going to be " + newAge);

        }
```