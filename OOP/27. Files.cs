using System.IO;
using System.ComponentModel.DataAnnotations;

namespace LearningCSharpWithKmithu
{  
    class Program 
    {         
        static void Main(string[] args)
        {
            // Files : AppendText(), Copy(), Create(), Delete(), Exists(), ReadAllText(), Replace(), WriteAllText().
            string writeText = "Hello World!";
            File.WriteAllText("filename.txt", writeText);

            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine(readText);    
             
        }
    }
}