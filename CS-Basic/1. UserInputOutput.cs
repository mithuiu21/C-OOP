namespace LearningCSharpWithKmithu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Output

            Console.WriteLine("Hello, World!");
	    Console.Write("Hello World! ");
            Console.Write("I will print on the same line.");
		
	    //mathematical calculations
	    Console.Write(2+2);



            // C# User Input
            Console.WriteLine("Enter your Name:");           
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your Age");
            string agee = Console.ReadLine();
            int age = Convert.ToInt32(agee);

            Console.WriteLine("Your name is " +userName + " And your age is "+ age);

        }
    }
}