using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Name = "Tom";
            Console.WriteLine("name of the employee..."+emp1.Name);

            Employee emp2 = new Employee();
            Employee emp3 = new Employee();

            Console.WriteLine("number of employees:"+Employee.Counter);
        }
    }
}
