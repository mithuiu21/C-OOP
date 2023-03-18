using System.Runtime.InteropServices;
using System;

namespace LearningCSharpWithKmithu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch Case

            int x = 5;
            switch(x) { 
                case 0:
                    Console.WriteLine("Value of x is 0");
                    break;
                case 1:
                    Console.WriteLine("Value of x is 1");
                    break;
                case 10:
                    Console.WriteLine("Value of x is 10");
                    break;
                default:
                    Console.WriteLine("Unknown Value");
                    break;
            }

            int y = 125;
            switch(y%2)
            {
                case 0:
                    Console.WriteLine($"{y} is an even value ");
                    break;
                case 1:
                    Console.WriteLine($"{y} is an odd value");
                    break;  
            }

        }
    }
}