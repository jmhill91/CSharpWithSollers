using System;

namespace CSharpWithSollers
{
    
    class Program
    {
        //Field example
        int nonStaticField;
        static int staticField;

        //Property Example
        public object NonStaticProperty { get; set; }
        public static object StaticProperty { get; set; }

        //Method Example
        public void NonStaticMEthod() { }
        public static void StaticMethod() { }


        static void Main(string[] args)
        {
            //Class Members: field, property,method(non-static(object) static(class))

            Console.WriteLine("Please enter your name"); //output operation
            string userInput = Console.ReadLine();//David//"David"//Input Operation
            Console.WriteLine($"Good Morning:{userInput}");
            Console.ReadKey();
        }
    }
}
