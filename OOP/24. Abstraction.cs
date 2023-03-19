using System.ComponentModel.DataAnnotations;

namespace LearningCSharpWithKmithu
{
    // Abstract class
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
    class Cat : Animal
    {
        // The body of animalSound() is provided here
       public override void animalSound()
        {
            Console.WriteLine("The cat says : Mewee Meww");
        }
    }
    class Program 
    {        
        static void Main(string[] args)
        {
            // Abstract class
            Cat myCat = new Cat();
            myCat.animalSound();
            myCat.sleep();  
        }
    }
}