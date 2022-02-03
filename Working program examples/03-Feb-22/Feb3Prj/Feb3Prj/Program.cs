using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb3Prj
{
    class Program
    {
        int data;
        public int Age { get; }
        public string Name { get; } = "Jimin";
        public double Salary { get; } = 10000;
        public float Incentive { get; protected set; } 
        public string CompanyName { get; private set; }
        public Program()
        {
            Age = 26;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Program p1=new Program();
            p.CompanyName = "Zensar";
            p.data = 55;
            
            Console.WriteLine(p.Incentive+p.Age+p.Name+p.Salary);

            Object o=new object();
            Type t=o.GetType();
            Type t1=p.GetType();
            Type t2=p1.GetType();
            Console.WriteLine("Type is : {0} ",t);
            Console.WriteLine("HashCode is : {0} ",t.GetHashCode());
            Console.WriteLine("Type of Program : {0}",t1);
            Console.WriteLine("Hashcode of the program is :{0}",t1.GetHashCode());
            Console.WriteLine("Hashcode of programs p and p1 are : {0}, {1}",t1.GetHashCode(),t2.GetHashCode());
            Console.ReadKey();
        }
    }
}
