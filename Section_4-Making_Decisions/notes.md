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

# Enhanced if Statements - Ternary Operators

```cs
//=[condition] ? [first expression] : [second expression]

//condition has to be either true or false

//The conditional Operator is right-associative

//That means, that a ? b : c ? d : e

// is evaluated as a ? b : (c ? d : e)

//The conditional Operator cannot be overloaded.

//in celcius
//Play around with that Value
```

```cs
int temperature = -5;

//Our result
string stateOfMatter;

//Is the Temperature below 0 Degree Celsius?
if(temperature < 0)
{
    stateOfMatter = "solid";
}
//Is the Temperature higher than 100 Degree Celcius?
else if(temperature > 100)
{
    stateOfMatter = "gas";
}
//In all other Cases it must be liquid.
else
{
    stateOfMatter = "liquid";
}

Console.WriteLine("State of Matter is {0}", stateOfMatter);

//The same result can be achieved by this
//The enhanced Version of the If-Else-Statement from above
stateOfMatter = temperature < 0 ? "solid" : (temperature > 100 ? "gas" : "liquid");

Console.WriteLine("State of Matter is {0}", stateOfMatter);

//To make sure the Console keeps open
Console.Read();
```
