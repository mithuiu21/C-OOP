using System.ComponentModel.DataAnnotations;

namespace LearningCSharpWithKmithu
{
    internal class Program 
    {
        class Car
        {
            public string color = "Red";
        }

        //Multiple Classes
        class Books
        {
            public string name;
            public string author;
            public int  Year;
            public void Messages()
            {
                Console.WriteLine("Martin Lings");
            }

        }
        static void Main(string[] args)
        {
            //a class is a template for objects, and an object is an instance of a class.
            //public keyword is called an access modifier
            //Multiple Classes and Objects

            Car myObj = new Car();
            Console.WriteLine(myObj.color);


            Books myBook = new Books();
            myBook.name = "Think and Grow Rich";
            myBook.author = "Napoleon Hill";
            myBook.Year = 2020;

            Books myBook2 = new Books();
            myBook2.name = "As A Man Thinketh";
            myBook2.author = "James Allen";
            myBook2.Year = 2021;

            Console.WriteLine(myBook.name);
            Console.WriteLine(myBook2.name);
            myBook.Messages();

        }
    }
}