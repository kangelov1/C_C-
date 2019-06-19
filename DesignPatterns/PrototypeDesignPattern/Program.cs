using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal sally = new Sheep("Sally", "Blah");
            Animal test = sally;
            Console.WriteLine("Finished");
        }
    }
}
