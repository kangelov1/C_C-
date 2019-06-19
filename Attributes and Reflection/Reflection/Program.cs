using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type T = Type.GetType("Reflection.Customer");
            Console.WriteLine("Fullname: " + T.FullName);
            Console.WriteLine("Just name:" + T.Name);
            Console.WriteLine("Namespace name: " + T.Namespace);
            Console.WriteLine();

            Customer c1 = new Customer();
            Type T1 = c1.GetType();
            Console.WriteLine(T1.FullName);

            Console.WriteLine("Properties");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                Console.WriteLine(prop.PropertyType.Name + " " + prop.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Methods");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }

            Console.WriteLine("Constructors");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constr in constructors)
            {
                Console.WriteLine(constr.ToString());
                Console.WriteLine(constr.GetParameters());
            }

            Type T2 = typeof(Customer);
            Customer customer1 = new Customer();
            customer1.GetType();
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get;set; }
        public Customer(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public Customer()
        {
            this.ID = -1;
            this.Name = string.Empty;
        }
        public void PrintID()
        {
            Console.WriteLine("ID={0}",this.ID);
        }
        public void PrintName()
        {
            Console.WriteLine("Name={0}",this.Name);
        }
    }
}
