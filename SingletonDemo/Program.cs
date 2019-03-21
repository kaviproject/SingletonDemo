using System;
using System.Security.Cryptography.X509Certificates;

namespace SingletonDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PrintFirstMethod();

            PrintSecondMethod();

            Console.WriteLine("--------------------------------------");
            /* This method is avoiding the singleton pattern because count value is showing 2 that means its instantiating 2 times.
             to avoid this scenario we need to add sealed class in the singleton method*/
            //Singleton.DerivedSingleton derviedObj = new Singleton.DerivedSingleton();
            //derviedObj.PrintDetails("Hello Inheritance");
            Console.ReadLine();
        }

        private static void PrintSecondMethod()
        {
            var s2 = Singleton.GetInstance;
            s2.PrintDetails("Still count value is 1 means its instantiantiating only once and 2nd message");
        }

        private static void PrintFirstMethod()
        {
            var s1 = Singleton.GetInstance;
            s1.PrintDetails("This is fist message");
        }
    }
}