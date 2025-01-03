/* 
    Type Casting
    1. Implicit Type Casting
        a. It is also known as Widening Conversion
        b. It is done automatically by the compiler
        c. It is also known as Upcasting
        d. It is done when the target type is larger than the source type
        e. e.g. char -> int -> long -> float -> double
    2. Explicit Type Casting
        a. It is also known as Narrowing Conversion
        b. It is done manually by the programmer
        c. It is also known as Downcasting
        d. It is done when the target type is smaller than the source type
        e. e.g. double -> float -> long -> int -> char
    3. Type Conversion
        a. It is the process of converting the value of one data type to another data type
        b. It is also known as Type Casting
        c. It is of two types
            i. Implicit Type Conversion
            ii. Explicit Type Conversion
    4. Parse Method
        a. It is used to convert a string into an integer
        b. It is a static method
        c. It is a part of the int class
        d. It throws an exception if the conversion fails
    5. TryParse Method
        a. It is used to convert a string into an integer
        b. It is a static method
        c. It is a part of the int class
        d. It does not throw an exception if the conversion fails
        e. It returns a boolean value
*/

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