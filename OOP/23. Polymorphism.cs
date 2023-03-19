using System.ComponentModel.DataAnnotations;

namespace LearningCSharpWithKmithu
{
    class Program 
    { 
        // class Animal
        //{
        //    public void animalSound()
        //    {
        //        Console.WriteLine("The animal makes a sound");
        //    }
        //}
        //class Cat : Animal
        //{
        //    public void animalSound()
        //    {
        //        Console.WriteLine("The cat says : Meww Meww Meww");
        //    }
        //}

        //class Dog : Animal
        //{
        //    public void animalSound()
        //    {
        //        Console.WriteLine("The dog says : bow bow");
        //    }
        //}

        //
        class Animal
        {
            public virtual void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }
        class Cat : Animal
        {
            public override void animalSound()
            {
                Console.WriteLine("The cat says : Meww Meww Meww");
            }
        }

        class Dog : Animal
        {
            public override void animalSound()
            {
                Console.WriteLine("The dog says : bow bow");
            }
        }
        static void Main(string[] args)
        {
            // Polymorphism

            Animal myAnimal = new Animal();
            Animal myCat = new Cat();
            Animal myDog = new Dog();

            myAnimal.animalSound();
            myCat.animalSound();
            myDog.animalSound();    


        }
    }
}