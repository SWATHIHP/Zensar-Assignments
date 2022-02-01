using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//base class for all the classes is object class
namespace Jan28ConsolePrj
{
    class Employee
    {
        int Eid;
        string Ename;
        string Cname;
        float Salary;

        public Employee(int id, string ename, string cname, float sal)
        {
            Eid = id;
            Ename = ename;
            Cname = cname;
            Salary = sal;
        }

        public override string ToString()
        {
            return $"EmpId : {Eid} with Name : {Ename} works with : {Cname} and earns rs: {Salary}";
            //return string.Format("Empid:" +" " Eid + "Emp Name:" + " " + Ename);
        }
        static void Main()
        {
            List<Employee> emplist = new List<Employee>();//list constructor
            emplist.Add(new Employee(111, "Eva", "Zensar", 23000));
            emplist.Add(new Employee(531, "Max", "Zensar", 33000));
            emplist.Add(new Employee(190, "Walker", "Zensar", 13000));

            foreach (Employee e in emplist)
            {
                Console.WriteLine($"Employee id {e.Eid} with Employee name {e.Ename} with company {e.Cname} with salary{e.Salary}");
                Console.WriteLine(e.ToString());
            }
        }
    }
    class GenericList
    {
       


        
    }
}
