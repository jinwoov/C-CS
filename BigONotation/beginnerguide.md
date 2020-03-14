# A Beginner's guide to big O notation
- Big O describe the execution time required or the space used in memory or on disk by an algorithm.
- O(1)
    - describes an algorithm that will always execute in the same time 
    ```
    ool IsFirstElementNull (IListM<string> elements)
    {
        return elements[0] == null;
    }

- O(N)
    ```
    example of loop 
    bool ContainsValue(IList <string> elements, string value)
    {
        foreach (var element in elements)
        {
            if (element == value) return true;
        }
        return false;
    }
    ```
- O(N2)
    ```
    nested for loop
      
    bool ContainsDuplicates(IList<string> elements)
    {
        for (var outer = 0; outer < elements.Count; outer++)
        {
            for (var inner = 0; inner < elements.Count; inner++)
            {
                if (outer == inner) continue;

                if (elements[outers] == elements[inner]) return true;
            }
        }
        reutrn false;
    }
    ```
- O(2N)
    - denotes alg that growth doubles with each addition to the input data set.
    ```
    int Fibonacci(int number)
    {
        if (number <=1) return number;
        return Fibonacci(number - 2) + Fibonacci (number - 1);
    }
    ```
- Logarithms
     - Binary search technique used to search sorted data sets.
    - if target value is higher than the value of the probe element it will take the upper half of the data set and perform the same operation against it.
    - `O(log N)` is this type of algorithm where you half the data sets 