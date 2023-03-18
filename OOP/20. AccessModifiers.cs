using System.ComponentModel.DataAnnotations;

namespace LearningCSharpWithKmithu
{
    class Book
    {
       // private string book = "You2";
        public string book1 = "You2";
    }

    class Car 
    {
        private string model = "Mustang";

        
        static void Main(string[] args)
        {
            //To control the visibility of class members (the security level of each individual class and class member).
            //To achieve "Encapsulation" - which is the process of making sure that "sensitive" data is hidden from users.

            Car myObj = new Car();
            Console.WriteLine(myObj.model);

            Book myBook = new Book();
            Console.WriteLine(myBook.book1);
        }
    }
}