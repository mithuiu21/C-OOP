using System.Runtime.InteropServices;
using System;

namespace LearningCSharpWithKmithu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Operators
            // Operators are used to perform operations on variables and values.
            // Addition(+), Subtraction(-), Multiplication(*), Division(/), Modulus(%), Increment(++), Decrement(--)

            int x = 10 + 10;
            Console.WriteLine(x);


            //Assignment
            // =, +=, -=, *=, /=, %=, &=, |=, ^=, >>=, <<=

            int y = 10;
            y += 5;
            Console.WriteLine(y);

            int z = 10;
            z %= 3;
            Console.WriteLine(z);

            //Comparison
            // Equal to(==), Not equal (!=), Greater than (>), Less than (<), Greater than or equal to (>=), Less than or equal to (<=)

            int p = 6;
            int q = 2;
            Console.WriteLine(p > q);


            //Logical Operators
            // AND (&&), OR (||), NOT (!)

            int k = 3; 
            Console.WriteLine(k > 2 && k < 10);

        }
    }
}