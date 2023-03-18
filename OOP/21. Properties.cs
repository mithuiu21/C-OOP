using System.ComponentModel.DataAnnotations;

namespace LearningCSharpWithKmithu
{
     
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Person2
    {
        public string Name2 { get; set; }
    }
    class Program 
    { 
        static void Main(string[] args)
        {
            //Properties
            //Better control of class members (reduce the possibility of yourself (or others) to mess up the code)
            //Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)

            Person person = new Person();
            person.Name = "Liam";
            Console.WriteLine(person.Name);

            Person2 person2 = new Person2();
            person2.Name2 = "Manson";
            Console.WriteLine(person2.Name2);
        }
    }
}