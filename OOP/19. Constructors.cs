using System.ComponentModel.DataAnnotations;

namespace LearningCSharpWithKmithu
{
    class Program 
    {
        public string name;
        public string author;
        public int year;
        
        // Create a class constructor with a parameter
        public Program(string bookName, string Author, int Year)
        {
            name = bookName;
            author = Author;
            year = Year;
        }
        static void Main(string[] args)
        {
	    //Constructors 
            Program MyBook = new Program("The SAONGF", "Mark Manson", 2020);
            Console.WriteLine(MyBook.name + " " + MyBook.author + " " + " " + MyBook.year);
        }
    }
}