# Arrays (C# Programming Guide)

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
- 

