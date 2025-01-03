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

### Assignment-02

Create a program to display the details of a product.

- Name: Apple Iphone 15 Pro Max
- Price: $1500.50
- Category: Mobile Phone
- Available: True
- Sold: 5

```c#
using System;
class Test
{
    public static void Main(String[] args)
    {
        string deviceName = "Apple Iphone 15 Pro Max";
        double price = 1500.50;
        string category = "Mobile Phone";
        bool available = true;
        int sold = 5;

        Console.WriteLine("Name: " + deviceName);
        Console.WriteLine("Price: $" + price);
        Console.WriteLine("Category: " + category);
        Console.WriteLine("Available: " + available);
        Console.WriteLine("Sold: " + sold);
    }
}
```

### Const and Multiple Variables in C#

Constants are immutable values which are known at compile time and do not change for the life of the program. Multiple variables can be declared and initialized in a single line.

### Const and Multiple Variables

- `const` is used to declare a constant variable
- `const` always has to be initialized at the time of declaration
- Multiple variables can be declared in a single line. For example: `int x = 5, y = 6, z = 50; int a = b = c = 10;`

#### Example:

```c#
using System;
class Variables
{
    public static void Main(string[] args)
    {
        const string productName = "Apple Iphone 15 Pro Max";
        const double productPrice = 1500.50;

        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Product Price: $" + productPrice);

        int x = 5, y = 6, z = 50;
        int a, b, c;
        a = b = c = 10;
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}
```

### Type Casting in C#

Type casting is the process of converting a variable from one data type to another. There are two types of type casting:

1. **Implicit Type Casting (Widening Conversion)**

   - Done automatically by the compiler
   - Also known as Upcasting
   - Occurs when the target type is larger than the source type
   - Example: `char -> int -> long -> float -> double`

2. **Explicit Type Casting (Narrowing Conversion)**
   - Done manually by the programmer
   - Also known as Downcasting
   - Occurs when the target type is smaller than the source type
   - Example: `double -> float -> long -> int -> char`

### Type Conversion

Type conversion is the process of converting the value of one data type to another data type. It is also known as type casting and can be of two types:

- Implicit Type Conversion
- Explicit Type Conversion

### Parse Method

- Used to convert a string into an integer
- It is a static method
- Part of the `int` class
- Throws an exception if the conversion fails

### TryParse Method

- Used to convert a string into an integer
- It is a static method
- Part of the `int` class
- Does not throw an exception if the conversion fails
- Returns a boolean value indicating success or failure

#### Example:

```c#
using System;

class Test
{
     public static void Main(string[] args)
     {
          // Implicit Type Casting
          int num = 100;
          float f = num;
          Console.WriteLine(f);

          // Explicit Type Casting
          float f1 = 123.45F;
          int num1 = (int)f1;
          Console.WriteLine(num1);

          // Type Conversion
          int num2 = 100;
          string str = num2.ToString();
          Console.WriteLine(str);

          // Parse Method
          string str1 = "100";
          int num3 = int.Parse(str1);
          Console.WriteLine(num3);

          // TryParse Method
          string str2 = "500";
          int num4 = 0;
          bool isConversionSuccessful = int.TryParse(str2, out num4);
          if (isConversionSuccessful)
          {
                Console.WriteLine(num4);
          }
          else
          {
                Console.WriteLine("Please enter a valid number");
          }
     }
}
```
