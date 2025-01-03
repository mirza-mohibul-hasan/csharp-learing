## Basic Structure of C# Program

### Steps:

1. Create a Class
2. Create a Main Method
   - Main Method is the entry point of the program
   - It is a static method
   - It is a void method
   - It is a public method
3. Write the code inside the Main Method
4. Define System Namespace so that we can use Console class without writing fully qualified name

```c#
using System;
class Test
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
    }
}
```

### Assignment-01

1. WriteLine print with new line
2. Write print without new line in the end

```c#
using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("My name is Mirza Mohibul Hassan");
        Console.WriteLine("I am 24 years old");
        Console.WriteLine("I am from Bangladesh");
        Console.WriteLine("I am a student of Computer Science and Engineering");
        Console.WriteLine("I am a software engineer");
    }
}
```

### Escape Sequences in C#

Escape sequences are used to represent special characters within string literals.

#### Common Escape Sequences:

- `\n` - New Line
- `\t` - Tab
- `\\` - Backslash
- `\"` - Double Quote
- `\` - Escape Character

```c#
using System;
class Test
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        Console.WriteLine("Hello\tWorld");
        Console.WriteLine("Hello\nWorld");
        Console.WriteLine("Hello\\World");
        Console.WriteLine("\"Hello World\"");
    }
}
```

### Comments in C#

Comments are used to explain code and make it more readable. They are ignored by the compiler.

#### Types of Comments:

1. Single-line comments
2. Multi-line comments

#### Examples:

```c#
// This is a single line comment
/* This is a multi-line comment */

using System;
class Test
{
    public static void Main(string[] args)
    {
        Console.WriteLine("// This is a single line comment");
        Console.WriteLine("/* This is a multi-line comment */");
    }
}
```

### Variables and Data Types in C#

Variables are used to store data, and data types are used to define the type of data that a variable can store.

#### Common Data Types:

- `int` - stores integers (whole numbers), without decimals, such as 123 or -123
- `double` - stores floating point numbers, with decimals, such as 19.99 or -19.99
- `char` - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
- `string` - stores text, such as "Hello World". String values are surrounded by double quotes
- `bool` - stores values with two states: true or false

#### Variable Naming Rules:

- Variable names are case-sensitive (name and Name are different variables)
- Variable names must start with a letter or an underscore
- Variable names can only contain letters, numbers, and underscores
- Variable names cannot contain whitespaces. If you need a space, use an underscore (\_)
- Variable names cannot be a C# keyword. For example, int, double, string etc.
- Cannot start with a number. For example, 1name is invalid
- Cannot contain special characters except underscore(\_). For example, @, #, $, % etc.

#### Example:

```c#
using System;
class Variables
{
    public static void Main(string[] args)
    {
        int myNum = 5;               // Integer (whole number)
        double myDoubleNum = 5.99D;  // Floating point number
        char myLetter = 'D';         // Character
        bool myBool = true;          // Boolean
        string myText = "Hello";     // String

        Console.WriteLine(myNum);
        Console.WriteLine(myDoubleNum);
        Console.WriteLine(myLetter);
        Console.WriteLine(myBool);
        Console.WriteLine(myText);
    }
}
```
