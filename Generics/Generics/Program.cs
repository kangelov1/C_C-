using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool Equal = Calculator<int>.AreEqual(1, 2);
            //Console.WriteLine(Equal);
            //int i = 10;
            //int j = 10;


            //Console.WriteLine(i==j);
            //Console.WriteLine(i.Equals(j));

            //Direction direction1 = Direction.East;
            //Direction direction2 = Direction.East;
            //Console.WriteLine(direction1 == direction2);
            //Console.WriteLine(direction1.Equals(direction2));

            Customer c1 = new Customer();
            c1.firstName = "Simon";
            c1.lastName = "Tan";

            Customer c2 = new Customer();
            c2.firstName = "Simon";
            c2.lastName = "Tan";

            
            Console.WriteLine(c1==c2);
            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine(c1.firstName.Equals(c2.firstName));
            Console.WriteLine(c1.firstName == c2.firstName);
            Console.WriteLine(c1.GetHashCode());
        }
    }
    public class Calculator<T>
    {
        public static bool AreEqual(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
    public enum Direction
    {
        East = 1,
        West = 2,
        North = 3,
        South = 4
    }
    public class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if (!(obj is Customer)) { return false; }
            return this.firstName == ((Customer)obj).firstName && this.lastName == ((Customer)obj).lastName;
        }
        public override int GetHashCode()
        {
            return this.firstName.GetHashCode() ^ this.lastName.GetHashCode();
        }
    }
}
