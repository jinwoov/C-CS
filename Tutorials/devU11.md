# Working with strings

- manipulating the data is key skill
- the string data type is big data type and developer has to work with it in efficient way to minimize utilize the resource usage.
- `\` backslash is to escape the sequence
    - to put special chracter
    - ie. "My \"so-called\" life";
- you can make new line in string using \n
- for computer to display currency in where you are you would input `String.Format("{0:C}", 123.45)`
- `{0:N}` displays appropriate format of data.
- `{0:P}` displays percentage
- `{0: (###) ###-####}` shows the phone number format
- `.Substring(6)` grabs from sixth position and grab until the end.
- you can also grab from sixth position to certain position
    - ie. `Substring(6, 14)`
- `.ToUpper` grabs the string and change it to upper case
- `.Replace()` change everything in first argument and change it to second argument
- `.Remove()` can remove snippet by putting first and second arg
- `.Trim()` trim out extra spaces that are not needed.