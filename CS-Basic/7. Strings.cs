using System.Runtime.InteropServices;
using System;

namespace LearningCSharpWithKmithu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Strings
            // Length, ToUpper(), ToLower() 
            string greeting = "Hello there";
            Console.WriteLine(greeting);

            string txt = "Dhaka";
            Console.WriteLine(txt.Length);
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());

            // Concatenation
            string firstName = "Kamruzzaman";
            string lastName = "Mithu";
            string name = firstName + lastName;
            Console.WriteLine(name);

            string myName = string.Concat(firstName, lastName);
            Console.WriteLine(myName);


            // Interpolation
            string myname = $"My full name is: {firstName} {lastName} ";
            Console.WriteLine(myName);

            //Access Strings
            string myString = "Dhaka";
            Console.WriteLine(myString[1]);
            Console.WriteLine(myString.IndexOf("a"));

            // Substring()
            string myFullName = "Kamruzzaman Mithu";
            int charPos = myFullName.IndexOf("M");
            string myLastname = myFullName.Substring(charPos);
            Console.WriteLine(myLastname);

            // C# Special Characters
            // \' Single quote, \" Double quote, \\ Backslash 

            string text = "My home town is \'Khulna \' ";
            Console.WriteLine(text);

            // Other escape characters
            // \n New Line, \t Tab, \b Backspace
            string text2 = "Hello \nWorld!";
            Console.WriteLine(text2);
        }
    }
}