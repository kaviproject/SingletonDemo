using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDmeo
{
    public static class Converter
    {
        public static double ToFahrenhit(double celcius)
        {
            return celcius*(9 / 5) + 32;
        }

        public static double Tocelcius(double Farhenhit)
        {
            return Farhenhit - 32 * (5 / 9);
        }
    }
}
