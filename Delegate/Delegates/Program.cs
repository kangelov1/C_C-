using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public static void Main(string[] args)
        {
            //A delegate is a type safe function pointer
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee() { ID = 103, Name = "John", Salary = 6000, Experience = 6 });
            empList.Add(new Employee() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3 });

            IsPromotable promotable = new IsPromotable(Promote);
            Employee.PromoteEmployee(empList,promotable);
            Console.WriteLine("With Lambda");
            Employee.PromoteEmployee(empList, emp => emp.Salary < 5000);
        }
        public static bool Promote(Employee emp) {
            if (emp.Experience >= 5) 
            { return true; }
            else
            {
                return false;
            }
        }
        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> listOfEmployees,IsPromotable IsEligibleToPromote)
        {
            foreach (Employee emp in listOfEmployees)
            {
                if (IsEligibleToPromote(emp))
                {
                    Console.WriteLine(emp.Name + " promoted");
                }
            }
        }
    }
    public delegate void HelloFunctionDelegate(string Message);
    public delegate bool IsPromotable(Employee emp);
}
