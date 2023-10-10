using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {


        public static double FahrenheitToCelsius(double fahrenheit)
        {
            var result = (fahrenheit - 32)* 5/9;
            return fahrenheit;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {

            return
           (celsius +32) * 9/5;
        }
    }

}
