using System; //using System means that we can use classes from the System namespace.
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Hello //namespace is used to organize your code, and it is a container for classes and other namespaces.
{
    internal class Program//class is a container for data and methods, which brings functionality to your program. Every line of code that runs in C# must be inside a class. In our example, we named the class Program.
    {
        //static void Main(string[] args)
        //{
        //    //Write() and WriteLine():

        //    //It Writes Hello World And stays in same line for next command also
        //    //Console.Write("Hello World!"); //Console is a class of the System namespace, which has a WriteLine() method that is used to output/print text.In our example, it will output "Hello World!".

        //    /*It Writes 'from my first C# program' and goes into new Line for upcoming instruction*/
        //    //Console.WriteLine("From My First C# Program");

        //    //Comments:

        //    //This is Single Line Comment
        //    /*This is Multiline comment*/

        //    //Note: Every C# statement ends with a semicolon ;.

        //    //Note: C# is case-sensitive; "MyClass" and "myclass" have different meaning.

        //    /*Unlike Java, the name of the C# file does not have to match the class name, but they often do (for better organization). When saving the file, save it using a proper name and add ".cs" to the end of the filename. */

        //    //Reading Input from the User with ReadLine():
        //    //Console.ReadLine() is used to read input from the user. It waits for the user to enter a value and press Enter. The value entered by the user is stored in a variable.
        //    //For example, if you want to read a string input from the user, you can do it like this:
        //    //Console.WriteLine("Enter your name:"); //This will prompt the user to enter their name.
        //    //string name = Console.ReadLine(); //This will read the input from the user and store it in the variable name.
        //    //Console.WriteLine("Hello" + name); //This will print "Hello " followed by the name entered by the user.

        //    //Console.WriteLine("Enter your Father name:"); //This will prompt the user to enter their name.
        //    //string fname = Console.ReadLine(); //This will read the input from the user and store it in the variable name.
        //    //Console.WriteLine("Hello, " + fname + "!"); //This will print "Hello " followed by the name entered by the user, and then an exclamation mark.

        //    //Variables:

        //    /*Variables are containers for storing data values.

        //     In C#, there are different types of variables (defined with different keywords), for example:

        //            int - stores integers (whole numbers), without decimals, such as 123 or -123
        //            size:4 bytes
        //            double - stores large floating point numbers, with decimals, such as 19.99 or -19.99
        //            size:8 bytes
        //            char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
        //            size:2 bytes
        //            string - stores text, such as "Hello World". String values are surrounded by double quotes
        //            size:2 bytes per character
        //            bool - stores values with two states: true or false
        //            size:1 bit

        //           There are also other types of variables, such as long, float, decimal, etc. But these are the most commonly used ones.
        //           long- stores large integers (whole numbers), without decimals, such as 1234567890123456789 or -1234567890123456789
        //           size:8 bytes
        //           float - stores floating point numbers, with decimals, such as 19.99 or -19.99
        //           size:4 bytes
        //     */

        //    //Constants:
        //    //Constants are variables whose values cannot be changed during the execution of the program. In C#, you can declare a constant using the const keyword. For example, if you want to declare a constant named PI with a value of 3.14, you can do it like this const double PI= 3.14;:
        //    //const int H = 10;
        //    //int H = 20; //This will give an error because H is a constant and its value cannot be changed.

        //    //Declaring variables:
        //    //DataType VariableName = value;

        //    //int is a data type that can store whole numbers. intvariable is the name of the variable, and 5 is the value assigned to it.

        //    //int intvariable = 5;

        //    //double is a data type that can store decimal numbers. doublevariable is the name of the variable, and 5.5 is the value assigned to it.

        //    //double doublevariable = 5.5;

        //    //char is a data type that can store a single character. charvariable is the name of the variable, and 'A' is the value assigned to it.

        //    //char charvariable = 'A';

        //    //string is a data type that can store a string of characters. stringvariable is the name of the variable, and "Hello" is the value assigned to it.

        //    //string stringvariable = "Hello";
        //    //String stringvariable2 = 'World'; //This will give an error because string variables should be enclosed in double quotes.

        //    //bool is a data type that can store a boolean value. boolvariable is the name of the variable, and true is the value assigned to it.

        //    //bool boolvariable = true;
        //    //boolvariable = false; //This will change the value of boolvariable to false.

        //    //float b1 = 1.0; //By default, C# treats decimal numbers as double. So, if you want to assign a decimal number to a float variable, you need to add an f at the end of the number to indicate that it is a float.
        //    //float b = 5.5f; //Note that we added an f at the end of the number to indicate that it is a float.

        //    //Printing variables:
        //    //Console.WriteLine() is used to print the value of the variable to the console.
        //    //Console.WriteLine(intvariable); //This will print the value of intvariable to the console.
        //    //Console.WriteLine(doublevariable); //This will print the value of doublevariable to the console.
        //    //Console.WriteLine(charvariable); //This will print the value of charvariable to the console.
        //    //Console.WriteLine(stringvariable); //This will print the value of stringvariable to the console.
        //    //Console.WriteLine(boolvariable); //This will print the value of boolvariable to the console.
        //    //Console.WriteLine(); //can also be used to print multiple variables at once.
        //    //Console.WriteLine(stringvariable);//This will print the value of stringvariable to the console.
        //    //Console.WriteLine(boolvariable);//This will print the value of boolvariable to the console.
        //    //Console.WriteLine(intvariable + doublevariable); //This will print the sum of intvariable and doublevariable to the console.
        //    //Console.WriteLine(intvariable + doublevariable + charvariable); //This will print the sum of intvariable, doublevariable and charvariable to the console.
        //    //Console.WriteLine(intvariable + doublevariable + charvariable + stringvariable); //This will print the sum of intvariable, doublevariable, charvariable and stringvariable to the console.
        //    //Console.WriteLine(b); //This will print the value of b to the console.
        //    //Console.WriteLine(b1); //This will print the value of b1 to the console.


        //    //Note: You can also use the + operator to concatenate strings. For example, stringvariable + " World" will give you "Hello World".

        //    //You can also declare a variable without assigning the value, and assign the value later:

        //    //int intvariable2; //This declares a variable named intvariable2 of type int.
        //    //intvariable2 = 10; //This assigns the value 10 to intvariable2.
        //    //Console.WriteLine(intvariable2);

        //    ////Note that if you assign a new value to an existing variable, it will overwrite the previous value:
        //    //intvariable2 = 20; //This assigns the value 20 to intvariable2, overwriting the previous value of 10.
        //    //Console.WriteLine(intvariable2); //This will print the new value of intvariable2 to the console.

        //    //Type-casting:
        //    //Type-casting is the process of converting a variable from one data type to another. In C#, you can do this using the (type) operator. For example, if you want to convert an int to a double, you can do it like this:

        //    //There are two types of type-casting in C#:

        //    //Implicit type-casting: This is done automatically by the compiler when you assign a smaller data type to a larger data type. For example, if you assign an int to a double, the compiler will automatically convert the int to a double.
        //    //char int long float double

        //    //example:

        //    //int B = 5; //This declares a variable named B of type int and assigns the value 5 to it.
        //    //double a = B; //This assigns the value of B to a, which is of type double. The compiler automatically converts the int value of B to a double value and assigns it to a.
        //    //int z = a; //This will give an error because you cannot assign a double value to an int variable without type-casting. The compiler will not automatically convert the double value of a to an int value.

        //    //Explicit type-casting: This is done manually by the programmer when you assign a larger data type to a smaller data type. For example, if you assign a double to an int, you need to use the (int) operator to convert the double to an int.
        //    //double float long int char

        //    //example:

        //    //int a = 1.5;
        //    //This will give an error because you cannot assign a double value to an int variable without type-casting.
        //    //int xyz = (int)1.5; //This will convert the double value 1.5 to an int value 1, and assign it to the variable a.
        //    //Console.WriteLine(xyz); //This will print the value of a to the console.

        //    //Type-Casting using Convert Class and default methods:
        //    //Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) ,Convert.ToInt64 (long)

        //    //You can also use the Convert class to convert between different data types. For example, if you want to convert a string to an int, you can do it like this:
        //    //string str = "134"; //This declares a variable named str of type string and assigns the value "123" to it.
        //    //int num = Convert.ToInt32(str); //This converts the string value of str to an int value and assigns it to the variable num.
        //    //Console.WriteLine(num); //This will print the value of num to the console.

        //    //Taking Input from the User:
        //    //You can also take input from the user using the Console.ReadLine() method. For example, if you want to take an int input from the user, you can do it like this:

        //    //Console.WriteLine("Enter an Name:"); //This will prompt the user to enter an integer.
        //    //string name = Console.ReadLine(); //This will read the input from the user and store it in the variable name.
        //    //Console.WriteLine("Hello " + name); //This will print "Hello " followed by the name entered by the user.
        //    //Console.ReadLine();

        //    //Console.WriteLine("How Many Candies Do you want?"); //This will prompt the user to enter an integer.
        //    //string can = Console.ReadLine(); //This will read the input from the user and store it in the variable name.
        //    //Console.WriteLine("you will get 5 more candies " +(Convert.ToInt32(can) + 5) + " in few minutes."); //This will print "Hello " followed by the name entered by the user.

        //    //Operators:
        //    //Operators are used to perform operations on variables and values. In C#, there are different types of operators, such as:

        //    //Arithmetic operators: +, -, *, /, %, ++, --
        //    //Unary operators: +, -, ++, --

        //    //+ is used to add two numbers.
        //    //- is used to subtract two numbers.
        //    //* is used to multiply two numbers.
        //    // / is used to divide two numbers.
        //    // % is used to get the remainder of a division operation.
        //    // ++ is used to increment a variable by 1.
        //    // -- is used to decrement a variable by 1.
        //    //For example:

        //    //int a = 15; //This declares a variable named a of type int and assigns the value 5 to it.
        //    //int b = 4;//This declares a variable named b of type int and assigns the value 5 to it.

        //    //Console.WriteLine("Arithmatic: "+ (a + b)); //This will print the sum of a and b to the console.
        //    //Console.WriteLine("Subtract: "+(a - b)); //This will print the difference of a and b to the console.
        //    //Console.WriteLine("Multiply: "+(a * b)); //This will print the product of a and b to the console.
        //    //Console.WriteLine("Division: "+(a / b)); //This will print the quotient of a and b to the console.
        //    //Console.WriteLine("Modular: "+(a % b)); //This will print the remainder of a divided by b to the console.
        //    //Console.WriteLine("Increment: " +(a++)); //This will print the value of a and then increment it by 1.
        //    //Console.WriteLine("Decrement: " + (b--)); //This will print the new value of a to the console.



        //    //Assignment operators: =, +=, -=, *=, /=, %=
        //    //= is used to assign a value to a variable.
        //    //+= is used to add a value to a variable and assign the result to the variable.
        //    //-= is used to subtract a value from a variable and assign the result to the variable.
        //    //*= is used to multiply a variable by a value and assign the result to the variable.
        //    // /= is used to divide a variable by a value and assign the result to the variable.
        //    // %= is used to get the remainder of a division operation and assign the result to the variable.
        //    //For example:
        //    //int p = 16; //This declares a variable named p of type int and assigns the value 5 to it.
        //    //int q = 3; //This declares a variable named q of type int and assigns the value 10 to it.

        //    //Console.WriteLine("Addition Assignment: " + (p += q)); //This will print the value of p after adding the value of q to it.
        //    //Console.WriteLine("Subtraction Assignment: " + (p -= q)); //This will print the value of p after subtracting the value of q from it.
        //    //Console.WriteLine("Multiplication Assignment: " + (p *= q)); //This will print the value of p after multiplying it by the value of q.
        //    //Console.WriteLine("Division Assignment: " + (p /= q)); //This will print the value of p after dividing it by the value of q.
        //    //Console.WriteLine("Modular Assignment: " + (p %= q)); //This will print the value of p after getting the remainder of p divided by q.
        //    //Console.WriteLine("Assignment: " + (p = q)); //This will print the value of p after assigning the value of q to it.


        //    //Comparison operators: ==, !=, >, <, >=, <=
        //    //== is used to check if two values are equal.
        //    //!= is used to check if two values are not equal.
        //    //> is used to check if a value is greater than another value.
        //    //< is used to check if a value is less than another value.
        //    //>= is used to check if a value is greater than or equal to another value.
        //    //<= is used to check if a value is less than or equal to another value.
        //    //For example:
        //    //int m = 8; //This declares a variable named x of type int and assigns the value 8 to it.
        //    //int n = 10; //This declares a variable named y of type int and assigns the value 10 to it.
        //    //Console.WriteLine("Equal: " + (m == n)); //This will print true if m is equal to n, otherwise false.
        //    //Console.WriteLine("Not Equal: " + (m != n)); //This will print true if m is not equal to n, otherwise false.
        //    //Console.WriteLine("Greater Than: " + (m > n)); //This will print true if m is greater than n, otherwise false.
        //    //Console.WriteLine("Less Than: " + (m < n)); //This will print true if m is less than n, otherwise false.
        //    //Console.WriteLine("Greater Than or Equal To: " + (m >= n)); //This will print true if m is greater than or equal to n, otherwise false.
        //    //Console.WriteLine("Less Than or Equal To: " + (m <= n)); //This will print true if m is less than or equal to n, otherwise false.


        //    //Logical operators: &&, ||, !
        //    //&& is used to check if two conditions are true.
        //    //|| is used to check if at least one of two conditions is true.
        //    //! is used to check if a condition is false.
        //    //For example:
        //    //bool x = true; //This declares a variable named x of type bool and assigns the value true to it.
        //    //bool y = false; //This declares a variable named y of type bool and assigns the value false to it.
        //    //Console.WriteLine("Logical AND: " + (x && y)); //This will print true if both x and y are true, otherwise false.
        //    //Console.WriteLine("Logical OR: " + (x || y)); //This will print true if either x or y is true, otherwise false.
        //    //Console.WriteLine("Logical NOT: " + (!x)); //This will print true if x is false, otherwise false.


        //    //Bitwise operators: &, |, ^, ~, <<, >>
        //    //& is used to perform a bitwise AND operation.
        //    //| is used to perform a bitwise OR operation.
        //    //^ is used to perform a bitwise XOR operation.
        //    //~ is used to perform a bitwise NOT operation.
        //    //<< is used to perform a left shift operation.
        //    //>> is used to perform a right shift operation.
        //    //For example:
        //    //int a1 = 5; //This declares a variable named a of type int and assigns the value 5 to it.
        //    //int b1 = 3; //This declares a variable named b of type int and assigns the value 3 to it.
        //    //Console.WriteLine("Bitwise AND: " + (a1 & b1)); //This will print the result of a1 AND b1.
        //    //Console.WriteLine("Bitwise OR: " + (a1 | b1)); //This will print the result of a1 OR b1.
        //    //Console.WriteLine("Bitwise XOR: " + (a1 ^ b1)); //This will print the result of a1 XOR b1.
        //    //Console.WriteLine("Bitwise NOT: " + (~a1)); //This will print the result of NOT a1.
        //    //Console.WriteLine("Left Shift: " + (a1 << 1)); //This will print the result of a1 left shifted by 1 bit.
        //    //Console.WriteLine("Right Shift: " + (a1 >> 1)); //This will print the result of a1 right shifted by 1 bit.

        //    //Conditional operators: ?:, ??, ?[] , ?()
        //    //?: is used to check if a condition is true or false and return a value based on the result.
        //    //?? is used to check if a value is null and return a default value if it is.
        //    //?[] is used to check if an array element is null and return a default value if it is.
        //    //?() is used to check if a method returns null and return a default value if it does.
        //    //Null-coalescing operator: ??
        //    //Null-conditional operator: ?.
        //    //Null-coalescing assignment operator: ??=
        //    //Null-conditional assignment operator: ?=

        //    //Ternary operator: ? :
        //    //The ternary operator is a shorthand way of writing an if-else statement. It takes three operands: a condition, a value to return if the condition is true, and a value to return if the condition is false. For example:

            
        //}
    }
}
