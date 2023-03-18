namespace LearningCSharpWithKmithu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Variables

            string name = "Kamruzzaman Mithu";
            Console.WriteLine(name);

            //
            int myNumber = 2;
            Console.WriteLine(myNumber);

            int number;
            number = 3;
            Console.WriteLine(number);

            double myDoubleNum = 2.88D;
            char myChar = 'B';
            bool myBool = true;
            string myText = "Bangladesh";


            // C# Constants
            //const int myNumberr = 2;
            //myNumberr = 3; //Error


            // C# Display Variables
            string myName = "KMithu";
            Console.WriteLine("My Name is " + myName);

            string firstName = "Kamruzzaman";
            string lastName = "Mithu";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int p = 5;
            int q = 5;
            Console.WriteLine(p + q);

            // C# Multiple Variables
            int x = 1, y = 2, z = 3;
            Console.WriteLine(x + y + z);

            int num1, num2, num3;
            num1 = num2 = num3 = 20;
            Console.WriteLine(num1+num2+num3);

            // C# Identifiers
            int monthPerYear = 12;
            Console.WriteLine(monthPerYear);    

        }
    }
}