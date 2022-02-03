using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27thPrj
{
    interface IName
    {
        string Name { get; set; }//property declaration
    }
    class Employee :IName
    {
        string empname;
       // public string Name { get; set; }//automatic implementation of get property
        public string Name
        {
            get { return empname; }
            set { empname = value; }
        }
           
    }

    class Company:IName
    {
        int age { get; set; }
        string compnanyname { get; set; }
        public string Name//manual implementation of the name property
        {
            get { return compnanyname; }
            set { compnanyname = value; }
        }
    }
    class PropertiesInsideInterface
    {
        static void Main()
        {
            IName e = new Employee();
            e.Name = "Rivera";
            IName c=new Employee();
            c.Name = "Zensar";
            Console.WriteLine($"Employee Named :{ e.Name} works for {c.Name}";
            Company comp=new Company();
            comp.Name = "Jermy";
            comp.CompanyAge = 20;
            Console.WriteLine(comp.Name,comp.CompanyAge);
            Console.Read();
            }
    }
}
