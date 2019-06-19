using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate del1, del2, del3, del4;
            SampleDelegate del5 = new SampleDelegate(SampleMethodOne);
            del5 += SampleMethodTwo;
            del1 = new SampleDelegate(SampleMethodOne);
            del2 = new SampleDelegate(SampleMethodTwo);
            del3 = new SampleDelegate(SampleMethodThree);

            del4 = del1 + del2 + del3;
            del4();
            del4 -= del2;
            Console.WriteLine(Environment.NewLine);
            del4();
            Console.WriteLine(Environment.NewLine);
            del5();
            Console.WriteLine(Environment.NewLine);

            SampleDelegate2 del6 = new SampleDelegate2(SampleMethodFour);
            del6 += SampleMethodFive;
            Console.WriteLine(del6());

            int num = -1;
            SampleMethodSix(out num);
            Console.WriteLine(num);

        }
        public static void SampleMethodOne()
        {
            Console.WriteLine("Sample Method One Invoked");
        }
        public static void SampleMethodTwo()
        {
            Console.WriteLine("Sample Method Two Invoked");
        }
        public static void SampleMethodThree()
        {
            Console.WriteLine("Sample Method Three Invoked");
        }
        public static int SampleMethodFour() { return 1; }
        public static int SampleMethodFive() { return 2; }
        public static void SampleMethodSix(out int Number)
        {
            Number = 1;
        }
    }
    public delegate void SampleDelegate();
    public delegate int SampleDelegate2();
}
