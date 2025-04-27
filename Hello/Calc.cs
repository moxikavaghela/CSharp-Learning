using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    //This is a simple calculator program in C# that performs basic arithmetic operations.
    
    internal class Calc
    {
        static void Add(int a, int b)
        {
            Console.WriteLine("Addition: " + (a + b));
        }

        static void Sub(int a, int b) 
        {
            Console.WriteLine("Subtraction: " + (a - b));
        }
        static void Mul(int a, int b)
        {
            Console.WriteLine("Multiplication: " + (a * b));
        }
        static void Div(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            else
            {
                Console.WriteLine("Division: " + (a / b));
            }
        }
        static void Main(String[] args)
        {
            //Asking for User Name
            Console.WriteLine("Enter Your Name:");
            String name = Console.ReadLine();

            //Using User Name For Greeting 
            Console.WriteLine("Welcome To My Calculator "+name);

            //Asking for First Number
            Console.WriteLine("Enter First Number:");
            int a = Convert.ToInt32(Console.ReadLine());

            //Asking for Second Number
            Console.WriteLine("Enter Second Number:");
            int b = Convert.ToInt32(Console.ReadLine());

            //Asking for Operation
            Console.WriteLine("Select Operation (1.+, 2.-, 3.*, 4./): ");
            int op = Convert.ToInt32(Console.ReadLine());

            if (op == 1) 
            {
                Add(a, b);
            }
            else if (op == 2)            
            {
                Sub(a, b);
            }
            else if (op == 3)
            {
                Mul(a,b);
            }
            else if ( op == 4)
            {
                Div(a, b);
            }
            else
            {
                Console.WriteLine("Invalid Operation");
            }
        }
    }
}
