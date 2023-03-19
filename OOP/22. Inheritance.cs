using System.ComponentModel.DataAnnotations;

namespace LearningCSharpWithKmithu
{
    class Program 
    { 
        class Vehicle
        {
            public string brand = "Ford";
            public void honk()
            {
                Console.WriteLine("Tuut, tuut!");
            }
        }

        class Car : Vehicle
        {
            public string modelName = "Mustang";
        }
        static void Main(string[] args)
        {
            //Inheritanece
            Car myCar = new Car();
            myCar.honk();

            Console.WriteLine(myCar.brand + " " + myCar.modelName);
            
        }
    }
}