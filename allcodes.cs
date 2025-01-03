/* Basic Strucure of C# Program
Steps:
    1. Create a Class
    2. Create a Main Method
        a. Main Method is the entry point of the program
        b. It is a static method
        c. It is a void method
        d. It is a public method
    3. Write the code inside the Main Method
    4. Define System Namespace so that we can use Console class without writing fully qualified name

*/
// using System;
// class Test
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Hello World");
//     }
// }

/* Assignment-01 */
// using System;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("My name is Mirza Mohibul Hassan");
//         Console.WriteLine("I am 24 years old");
//         Console.WriteLine("I am from Bangladesh");
//         Console.WriteLine("I am a student of Computer Science and Engineering");
//         Console.WriteLine("I am a software engineer");
//     }
// }

/* Backslash and Escape Sequence
\n - New Line
\t - Tab
\\ - Backslash
\" - Double Quote
\ - Escape Character

*/
// using System;
// class Test
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Hello World");
//         Console.WriteLine("Hello\tWorld");
//         Console.WriteLine("Hello\nWorld");
//         Console.WriteLine("Hello\\World");
//         Console.WriteLine("\"Hello World\"");
//     }
// }

/* 
    Varibale and Data Types
    - Variables are used to store data
    - Data types are used to define the type of data that a variable can store
    -int - stores integers (whole numbers), without decimals, such as 123 or -123
    - double - stores floating point numbers, with decimals, such as 19.99 or -19.99
    - char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
    - string - stores text, such as "Hello World". String values are surrounded by double quotes
    - bool - stores values with two states: true or false

    Variuable Naming Rules:
    - Variable names are case-sensitive (name and Name are different variables)
    - Variable names must start with a letter or an underscore
    - Variable names can only contain letters, numbers, and underscores
    - Variable names cannot contain whitespaces. If you need a space, use an underscore (_)
    - Variable names cannot be a C# keyword. For example, int, double, string etc.
    - Can not  start with a number. For example, 1name is invalid
    - Can not contain special characters except underscore(_). For example, @, #, $, % etc.
*/
// class Variables
// {
//     public static void Main(string[] args)
//     {
//         int myNum = 5;               // Integer (whole number)
//         double myDoubleNum = 5.99D;  // Floating point number
//         char myLetter = 'D';         // Character
//         bool myBool = true;          // Boolean
//         string myText = "Hello";     // String

//         Console.WriteLine(myNum);
//         Console.WriteLine(myDoubleNum);
//         Console.WriteLine(myLetter);
//         Console.WriteLine(myBool);
//         Console.WriteLine(myText);
//     }
// }