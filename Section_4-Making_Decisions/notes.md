# Decisions in C#

## If Statement

```cs
if(condition)
{
    //what to do if condition is met
}
```

```cs
if(condition){
    //what to do if condition is met
}
else
{
    // what to do if condition is not met
}
```

```cs
if(condition)
{
    //what to do if condition is met
}
else if (condition)
{
    // what to do if condition2 is met
}
else
{
    // what to do if condition is not met
}
```

# Intro To TryParse Method

-   allows converting strings into numeric data types.

For Example:

-   By using the TryParse() method you can convert a string like "128" into a numeric data type like and integer.

-   TryParse() often gets used when the user submits input

1. We need a string

```cs
static void Main(string[] args)
{
    string numberAsString = "128";

}
```

2. Then we need to create a variable to store the parsed value

```cs
static void Main(string[] args)
{
    string numberAsString = "128";
    int parsedValue;
}
```

3. Try to parse the string (returns a boolean)

```cs
static void Main(string[] args)
{
    string numberAsString = "128";
    int parsedValue;
    bool success = int.TryParse(numberAsString, out parsedValue);
    // The returned boolean is true when parsing was successful
}
```

4. Work with the result

```cs
static void Main(string[] args)
{
    string numberAsString = "128";
    int parsedValue;

    bool success = int.TryParse(numberAsString, out parsedValue);

    if (success)
        Console.WriteLine("Parsing successful - number is " + parsedValue);
    else
        Console.WriteLine("Parsing Failed");
}
```

You can also use other numeric data types fo parsing like **float** or **double**

```cs
static void Main(string[] args)
{
    string numberAsString = "128";
    float parsedValue;

    bool success = float.TryParse(numberAsString, out parsedValue);

    if (success)
        Console.WriteLine("Parsing successful - number is " + parsedValue);
    else
        Console.WriteLine("Parsing Failed");
}
```

Parsing fails when the string can not be converted into the desired data type.
if a letter or character is used for example.
