# C# language
- C# is object oriented langage that enables developers to build application on the .NET Framework. 
- To override virtual methods in a parent class, C# require the `override` keyword
- delegates enables type-safe event notification
- If you have to interact with other Window software, you can use C# through process call Interop.
- C# runs on .NET framework that includes common language runtime (CLR). 
- IL codes and resources are stored on executable file called an assembly.
- Code that are ran through CLR is called managed code which compiled into native machine lanaguage.

- type[] arrayName;
- To create a single array
```
class TestArraysClass
{
    static void Main()
    {
        // Declare a single-dimensional array. 
        int[] array1 = new int[5];

        // Declare and set array element values.
        int[] array2 = new int[] { 1, 3, 5, 7, 9 };

        // Alternative syntax.
        int[] array3 = { 1, 2, 3, 4, 5, 6 };

        // Declare a two dimensional array.
        int[,] multiDimensionalArray1 = new int[2, 3];

        // Declare and set array element values.
        int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

        // Declare a jagged array.
        int[][] jaggedArray = new int[6][];

        // Set the values of the first array in the jagged array structure.
        jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
    }
}
```
- jagged array is array of arrays such that member array can be different sizes.
- ie.
```
[123],
[1234]
and to declare you can 
int[][] jaggedArray = new int[6][];
```
- Once the each dimension are established when the array instance is creeated, these values can't be cahnged during the lifetime of the instance.
- In C# arrays are objects and not addresseable regions of contiguous memory as in c and c++.
- Array provides useful methods like sorting, searching, and copying arrays
- `Array.Rank` is property that such that 2 dimesional array will return 2 and 1 dimensional array being 1.
- the jagged array is ranked 1.
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
- following code block creates 4 by 2 rows two-dimensinoal array
```
int[,] array = new int[4, 2];
```
- two create three dimensional array
```
int[, ,] array1 = new int[4, 2, 3];
```
- To initialize array
```
// Two-dimensional array.
int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
// The same array with dimensions specified.
int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
// A similar array with string elements.
string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                        { "five", "six" } };

// Three-dimensional array.
int[, ,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, 
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
// The same array with dimensions specified.
int[, ,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, 
                                       { { 7, 8, 9 }, { 10, 11, 12 } } };

// Accessing array elements.
System.Console.WriteLine(array2D[0, 0]);
System.Console.WriteLine(array2D[0, 1]);
System.Console.WriteLine(array2D[1, 0]);
System.Console.WriteLine(array2D[1, 1]);
System.Console.WriteLine(array2D[3, 0]);
System.Console.WriteLine(array2Db[1, 0]);
System.Console.WriteLine(array3Da[1, 0, 1]);
System.Console.WriteLine(array3D[1, 1, 2]);

// Getting the total count of elements or the length of a given dimension.
var allLength = array3D.Length;
var total = 1;
for (int i = 0; i < array3D.Rank; i++) {
    total *= array3D.GetLength(i);
}
System.Console.WriteLine("{0} equals {1}", allLength, total);

// Output:
// 1
// 2
// 3
// 4
// 7
// three
// 8
// 12
// 12 equals 12
```

- you can initialize the array without specifying the rank
```
int[,] array4 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
```

- Example of declaring jagged array
```
int[][] jaggedArray2 = new int[][] 
{
    new int[] { 1, 3, 5, 7, 9 },
    new int[] { 0, 2, 4, 6 },
    new int[] { 11, 22 }
};


or shorthand form 

int[][] jaggedArray3 = 
{
    new int[] { 1, 3, 5, 7, 9 },
    new int[] { 0, 2, 4, 6 },
    new int[] { 11, 22 }
};

```

- You can mix jagged and multidimensional arrays
```
int[][,] jaggedArray4 = new int[3][,] 
{
    new int[,] { {1,3}, {5,7} },
    new int[,] { {0,2}, {4,6}, {8,10} },
    new int[,] { {11,22}, {99,88}, {0,9} } 
};
```

- to show the array 
```
static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));
```
- Array.Reverse change the order of array

