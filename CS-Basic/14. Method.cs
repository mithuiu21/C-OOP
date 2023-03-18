using System.Runtime.InteropServices;
using System;
using System.Security.AccessControl;

namespace LearningCSharpWithKmithu
{
    internal class Program
    {
        // C# Methods : / function
        static void MyMethod(string fname)
        {
            Console.WriteLine(fname + "Rafsan");
        }

        //Return Values:
        static int MyReturnMethod(int x, int y)
        {
            return x + y;
        }

        //Method Overloading:
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }
        static double PluseMethod(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            // Calling Methods
            MyMethod("Joni");
            MyMethod("Pit");

            //Return Values Methods
            int z = MyReturnMethod(1, 2);
            Console.WriteLine(z);

            //Method Overloading
            int p = PlusMethod(2, 2);
            Console.WriteLine("Int : " + p);
            double q = PluseMethod(2.5, 2.5);
            Console.WriteLine("Double: " + q);
        }       
    }
}