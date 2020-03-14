# Working with Dates and Times

- The default method `ToString()` helps to take coutnries and locale and present and dates and time in our country and culture
- `Console.WriteLine(myValue.ToShortDateString());` //month date and year only
- `Console.WriteLine(myValue.ToShortTimeString());` just displays time only
- `Console.WriteLine(myValue.ToLongDateString());` displays Tuesday, March 15, 2016
- `Console.WriteLine(myValue.ToLongTimeString());` displays time and seconds
- To add days `.AddDays()`
- To add hours `.AddHours()`
- TO subtract days or hour just add negative infront of integer value
- `Console.WriteLine(myValue.Month)` To see the months
- int parse is to turn string to integer
- `TimeSpan` shows the span of time