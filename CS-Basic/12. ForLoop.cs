using System.Runtime.InteropServices;
using System;

namespace LearningCSharpWithKmithu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# for loop

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // break in for loop
            for(int i = 0;i < 10; i++)
            {
                if( i == 5)
                {
                    break;
                }
                Console.WriteLine("Value of i: {0}",i);
            }

            // Nested for loop
            for (int i = 0; i < 2; i++)
            {
                for(int j = i; j < 4; j++)
                {
                    Console.WriteLine("Value of i: {0}, J:{1}",i,j);
                }
            }
        }
    }
}