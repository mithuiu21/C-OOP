using System.Runtime.InteropServices;
using System;

namespace LearningCSharpWithKmithu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Data Types

            // Integer Types - Int
            int myNum = 100000;
            Console.WriteLine(myNum);

            // Long 
            long num1 = 15000000000L;
            Console.WriteLine(num1);

            //Floating Point Types
            //The 'float' and 'double' data types can store fractional numbers.
            //you should end the value with an "F" for floats and "D" for doubles

            float fNum = 5.75F;
            Console.WriteLine(fNum);

            double dNum = 19.99D;
            Console.WriteLine(dNum);

            //Scientific Numbers
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);


            //Booleans 
            bool isTrue = true;
            bool isFalse = false;
            Console.WriteLine(isTrue);
            Console.WriteLine(isFalse);

            //Characters
            // The char data type is used to store a single character Like 'K' or 'M'

            char myGrade = 'A';
            Console.WriteLine(myGrade);

            // Strings
            //The string data type is used to store a sequence of characters (text)

            string greeting = "Hello World";
            Console.WriteLine(greeting);
        }
    }
}