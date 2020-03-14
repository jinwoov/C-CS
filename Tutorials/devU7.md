# ARRAY

- if more than declare array length, output gives you error.
- 

to reverse the string 

```
  string zig = "You can get what you want out of life if you help enough " +
                "other people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }


            Console.ReadLine();
```