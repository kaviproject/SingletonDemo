using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDmeo
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius = 37;
            double farhenhit = 98.6;
            Console.WriteLine("{0}{1}",celcius,Converter.ToFahrenhit(celcius));
            Console.WriteLine("{0}{1}", farhenhit, Converter.Tocelcius(farhenhit));
            Console.ReadLine();

        }
    }
}
