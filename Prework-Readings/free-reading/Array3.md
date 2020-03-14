# Single-Dimensional Arrays
- new operator is used to create the array and initalize the array elements to their default values.
- to initialize the array upon declaration, yu can supply it by {}
```
shortcut 
int[] array2 = { 1, 3, 5, 7, 9 };
string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
```
- you can declare array variable without initializing, but have to use `new` operator
```
int[] array3;
array3 = new int[] { 1, 3, 5, 7, 9 };   // OK
//array3 = {1, 3, 5, 7, 9};   // Error
```
- `Sometype` is a value type or reference type. 