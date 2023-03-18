namespace LearningCSharpWithKmithu
{
    internal class Program
    {
        static void MyMethod()
        {           
            Console.WriteLine("Method is called Function");
        }

        //Method with parameters
        static void MethodWPar(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }

        //Default Parameter
        static void CountryName(string country = "Australia")
        {
            Console.WriteLine(country);
        }
        // we used the void keyword in all examples, which indicates that the method should not return a value.


        //Method Return Values
        static int MySum(int x, int y)
        {
            return x + y;
        }

        // Name Arguments
        static void NameArg(string firstName, string middleName ,string lastName)
        {
            Console.WriteLine("His Name is:" + firstName + " " + middleName + " " + lastName);
        }

       /// Method Overloading
        static int PlusMethod(int p, int q)
        {
            return p + q;
        }
        static double PlusMethod(double p, double q)
        {
            return p + q;
        }
        
        static void Main(string[] args)
        {
            //Calling Methods
            MyMethod();
            MethodWPar("Liam", 15);
            CountryName("USA");
            CountryName();
            
            Console.WriteLine(MySum(5,5));
            int z = MySum(10,10);
            Console.WriteLine(z);

            NameArg(firstName: "Leonardo", middleName: "Di", lastName:"Caprio");

            //Overloading

            int myNumInt = PlusMethod(2, 2);
            double myNumDouble = PlusMethod(3.5, 3.5);
            Console.WriteLine(myNumInt);    
            Console.WriteLine(myNumDouble);

        }
    }
}