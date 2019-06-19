using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = 37;
            double fahrenheit = 98.6;

            Console.WriteLine(Converter.ToCelsius(fahrenheit).ToString());
            Console.WriteLine(Converter.ToFahrenheit(celsius).ToString());
        }
    }
}
