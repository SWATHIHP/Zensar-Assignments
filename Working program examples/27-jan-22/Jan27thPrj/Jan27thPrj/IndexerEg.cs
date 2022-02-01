using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27thPrj
{
    class Employees
    {
        //decl. properties
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        //constructor to initialize properties

        public Employees(int ID, string Name, double Salary)
        {
            this.ID = ID;
            this.Name = Name;
            this.Salary = Salary;
        }

        //defining indexers

        public object this[int index]
        {

            //get succesor to return values
            get
            {
                if(index == 0)
                    return ID;
                else if(index == 1)
                    return Name;
                else if(index == 2)
                    return Salary;
                else
                    return null;

            }

            //set succesor to assign values
            set
            {
                if(index==0)
                    ID=Convert.ToInt32(value);
                else if(index==1)
                    Name=Convert.ToString(value);
                else if(index==2)
                    Salary=Convert.ToDouble(value);
            }
        }

        //overloaded indexer
        public object this[string s]
        {
            get
            {
                if(s=="ID")
                    return ID;
                else if(s=="Name")
                    return Name;
                else if(s == "Salary")
                    return Salary;

            }
            set
            {
                if (s=="ID")
                    ID = Convert.ToInt32(value);
                else if (s=="Name")
                    Name = Convert.ToString(value);
                else if (s=="Salary")
                    Salary = Convert.ToDouble(value);
            }
        }

    }
    class IndexerEg
    {
        static void Main()
        {
            //create an instance of employees
            Employees emp = new Employees(111,"Bruce",25000.0);
            Console.WriteLine("EmployeeID =" + " " + emp[0]);
            Console.WriteLine("Name=" + " " + emp[1]);
            Console.WriteLine("Salary=" + " " + emp[2]);
            Console.WriteLine("------------After overloading method of indexer------------");
            Console.WriteLine("Employee ID:"+" "+emp["ID"]);
            Console.WriteLine("Employee Name:"+" "+emp["Name"]);
            Console.WriteLine("Employee Salary:"+" "+emp["Salary"]);
            emp["ID"] = 333;
            emp["Name"] = "Minho";
            emp["Salary"] = 55000;
            Console.WriteLine("============After Modification==============");
            Console.WriteLine("EmployeeID ="+ " "+emp["ID"]);
            Console.WriteLine("Name="+" "+emp["Name"]);
            Console.WriteLine("Salary="+" "+emp["Salary"]);
           

            Console.WriteLine(emp["ID"]);


        }
    }
}
