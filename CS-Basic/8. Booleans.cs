using System.Runtime.InteropServices;
using System;

namespace LearningCSharpWithKmithu
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // C# Booleans
           // YES / NO, ON / OFF, TRUE / FALSE

            bool True = true;
            bool False = false;
            Console.WriteLine(True);
            Console.WriteLine(False);

            int x = 10;
            int y = 20;
            Console.WriteLine(x > y);

            Console.WriteLine(2 < 3);
            int p = 2;
            Console.WriteLine( p == 3);

            int myAge = 25;
            int votingAge = 18;
            Console.WriteLine(myAge >= votingAge);
        }
    }
}