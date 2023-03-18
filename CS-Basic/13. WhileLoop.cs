using System.Runtime.InteropServices;
using System;
using System.Security.AccessControl;

namespace LearningCSharpWithKmithu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While Loop
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("i= {0}", i);
                i++; // increment
            }

            // Exit from the while loop
            int j = 0;
            while (true)
            {
                Console.WriteLine("j= {0}", j);
                j++;
                if (j > 10)
                    break;
            }

            // Nested while loop
            int p = 0, k = 1;
            while(p < 2)
            {
                Console.WriteLine("i = {0}", p);
                p++;
                while (k < 2)
                {
                    Console.WriteLine("j = {0}", k);
                    k++;
                }
            }


            // do...while loop 
            int m = 0;
            do
            {
                Console.WriteLine("m = {0}", m);
                m++;
            }while (m <5);

            int n = 0;
            do
            {
                Console.WriteLine("m = {0}", n);
                n++;
                if (n > 3)
                    break;
            }while(n < 5);
               
        }
    }
}