using System.ComponentModel.DataAnnotations;

namespace LearningCSharpWithKmithu
{
    internal class Program 
    {
        class Car
        {
            public string color = "Red";
        }
        static void Main(string[] args)
        {
            //a class is a template for objects, and an object is an instance of a class.
            //public keyword is called an access modifier
            //Multiple Classes and Objects

            Car myObj = new Car();
            Console.WriteLine(myObj.color);
        }
    }
}