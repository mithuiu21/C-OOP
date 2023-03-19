using System.ComponentModel.DataAnnotations;

namespace LearningCSharpWithKmithu
{  

    //Interface
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body )
    }

    // Pig "implements" the IAnimal interface
    class Dog : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The Dog says : Bow Bow");
        }
    }

    interface IFirstInterface
    {
        void myMethod();
    }
    
    interface ISecondInterface
    {
        void myOtherMethod();
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }
    class Program 
    {        
        static void Main(string[] args)
        {
            // Interface
            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();

        }
    }
}