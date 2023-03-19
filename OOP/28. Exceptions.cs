using System.IO;
using System.ComponentModel.DataAnnotations;

namespace LearningCSharpWithKmithu
{  
    class Program 
    {
        static void Main(string[] args)
        {
            // Exceptions

            //try
            //{
            //    int[] myNumbers = { 1, 2, 3 };
            //    Console.WriteLine(myNumbers[10]);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
                //}


            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Somthing went wrong.");
            }
            finally 
            { 
                Console.WriteLine("The 'try catch' is finished.");
            }
             
        }
    }
}