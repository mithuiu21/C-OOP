using System.Runtime.InteropServices;
using System;

namespace LearningCSharpWithKmithu
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // If...Else

            if(2 > 1)
            {
                Console.WriteLine("Two is greater than One");
            }

            int x = 20;
            int y = 10;
            if(x > y)
            {
                Console.WriteLine("x is greater than y");
            }


            if(x < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            if (x > 15)
            {
                Console.WriteLine("Good morning.");
            }
            else if (x < 25)
            {
                Console.WriteLine("Good evening.");
            }


            // Short hand if...else
            int number = 10;
            string result = (number < 12) ? "Good day" : "Good evening";
            Console.WriteLine(result);
        }
    }
}