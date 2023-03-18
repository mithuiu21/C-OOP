using System.Runtime.InteropServices;
using System;

namespace LearningCSharpWithKmithu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Type Casting
            // Type casting is when you assign a value of one data type to another type.

            double num = 8.88;
            int myNum = (int)num;
            Console.WriteLine(num);
            Console.WriteLine(myNum);

            // Type Conversion Methods
            //It is also possible to convert data types explicitly by using built-in methods,
            //such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long)

            int myInt = 8;
            double myDouble = 2.22;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(myBool));

        }
    }
}