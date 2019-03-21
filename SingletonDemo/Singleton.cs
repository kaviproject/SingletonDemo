using System;

namespace SingletonDemo
{
    /*
     *sealed restricts the inheritance
     */
    public sealed class Singleton
    {
        private static int counter;

        private static Singleton instance;
        /*
         * Private constructor ensures that object is not
         * instantiated other than with in the class itself
         */
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter);
        }
        /*
         * Public property is used to return only one instance of the class
         * levearging on the private property
         */
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        //cannot inherit the singleton method
        //public class DerivedSingleton : Singleton
        //{

        //}
    }
}