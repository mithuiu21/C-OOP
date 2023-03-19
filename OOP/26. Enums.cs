using System.ComponentModel.DataAnnotations;

namespace LearningCSharpWithKmithu
{  
    class Program 
    {        
        enum Level
        {
            Low,
            Medium,
            High
        }

        enum Months
        {
            January,
            February,
            March,
            April = 6,
            May,
            June,
            July
        }
        static void Main(string[] args)
        {
            // Enum
             Level myVar = Level.Low;
            Console.WriteLine(myVar);
            switch (myVar)
            {
                case Level.Low:
                    Console.WriteLine("Low level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case Level.High:
                    Console.WriteLine("High level"); 
                    break;
            }


            Months myMonths = (int)Months.January;
            Console.WriteLine(myMonths);

           Console.WriteLine((int)Months.May);

        }
    }
}