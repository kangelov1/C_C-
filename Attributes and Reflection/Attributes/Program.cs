using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Calculator.Add(10, 20);
            Console.WriteLine(res);
        }
    }
    public class Calculator
    {
        [Obsolete("Use method with list input")]
        public static int Add(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }
        public static int Add(int FirstNumber, int SecondNumber,int ThirdNumber)
        {
            return FirstNumber + SecondNumber + ThirdNumber;
        }
        public static int Add(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
