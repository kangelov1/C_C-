using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialCustomer c1 = new PartialCustomer();
            c1.FirstName = "Bill";
            c1.LastName = "Bill";
            Console.WriteLine(c1.GetFullName());
        }
    }
}
