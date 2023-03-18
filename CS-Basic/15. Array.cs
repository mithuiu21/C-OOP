using System;
using System.Linq;
namespace LearningCSharpWithKmithu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array

            int[] nums = { 1, 2, 3, 4, 5, };

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

             Console.WriteLine(nums.Length);
            //array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace
            Console.WriteLine(nums.Max());
            Console.WriteLine(nums.Min());
            Console.WriteLine(nums.Sum());

            // Sort an Array
            string[] cars = { "Volvo", " BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // Two-Dimensional Arrays
            int[,] numbers = { { 1, 4, 2 }, { 3, 5, 6 } };
            Console.WriteLine(numbers[0, 2]); //2
            Console.WriteLine(numbers[1,2]); //6

            numbers[0, 0] = 10;
            Console.WriteLine(numbers[0,0]);
            
            //Loop Through a 2D Array
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }

            for(int i = 0; i < numbers.GetLength(0); i++)
            {
                for(int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }

        }

        

        //public static void UpdateArray(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = arr[i] + 10;
        //    }
        //}
    }
}