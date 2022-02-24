using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    public class Employee
    {
        public int EmployeeId;
        public string FirstName;
        public string LastName;
        public string Title;
        public DateTime DOB;
        public DateTime DOJ;
        public string City;
    }
    class Assignment5
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>() {
                new Employee(){ EmployeeId=1001,FirstName="Malcolm",LastName="Daruwalla",Title="Manager",DOB=new DateTime(1984,11,16),DOJ=new DateTime(2011,6,8),City="Mumbai" },
                new Employee(){ EmployeeId=1002,FirstName="Asdin",LastName="Dhalla",Title="AsstManager",DOB=new DateTime(1984,08,20),DOJ=new DateTime(2012,7,7),City="Mumbai"},
                new Employee(){EmployeeId= 1003,FirstName="Madhavi",LastName="Oza",Title="Consultant",DOB=new DateTime(1987,11,14),DOJ=new DateTime(2015,4,12),City="Pune"},
                new Employee(){ EmployeeId=1004,FirstName="Saba",LastName="Shaikh",Title="SE",DOB=new DateTime(1990,6,3),DOJ=new DateTime(2016,2,2),City="Pune"},
                new Employee(){ EmployeeId=1005,FirstName="Nazia",LastName="Shaikh",Title="SE",DOB=new DateTime(1991,3,8),DOJ=new DateTime(2016,2,2),City="Mumbai"},
                new Employee(){ EmployeeId=1006,FirstName="Amit",LastName="Pathak",Title="Consultant",DOB=new DateTime(1989,11,7),DOJ=new DateTime(2014,8,8),City="Chennai"},
                new Employee(){ EmployeeId=1007,FirstName="Vijay",LastName="Natrajan",Title="Consultant",DOB=new DateTime(1989,12,2),DOJ=new DateTime(2015,1,6),City="Mumbai"},
                new Employee(){ EmployeeId=1008,FirstName="Rahul",LastName="Dubey",Title="Associate",DOB=new DateTime(1993,11,11),DOJ=new DateTime(2014,11,6),City="Chennai"},
                new Employee(){ EmployeeId=1009,FirstName="Suresh",LastName="Mistry",Title="Associate",DOB=new DateTime(1992,8,12),DOJ=new DateTime(2014,12,3),City="Chennai"},
                new Employee(){ EmployeeId=1010,FirstName="Sumit",LastName="Shah",Title="Manager",DOB=new DateTime(1991,4,12),DOJ=new DateTime(2016,1,2),City="Pune"}};


            //a.Display detail of all the employee


            foreach (var f in emplist)
            {
                Console.WriteLine(f.EmployeeId + "\t" + f.FirstName + "\t" + f.LastName + "\t" + f.Title + "\t" + f.DOB + "\t" + f.DOJ + "\t" + f.City);
            }
            Console.WriteLine();
            Console.WriteLine();

            //b. Display details of all the employee whose location is not Mumbai

            var e = emplist.Where(f => f.City != "Mumbai");
            foreach (var f in e)
            {
                Console.WriteLine(f.EmployeeId + "\t" + f.FirstName + "\t" + f.LastName + "\t" + f.Title + "\t" + f.DOB + "\t" + f.DOJ + "\t" + f.City);
            }
            Console.WriteLine();
            Console.WriteLine();

            //c. Display details of all the employee whose title is AsstManager

            e = emplist.Where(f => f.Title == "AsstManager");
            foreach (var f in e)
            {
                Console.WriteLine(f.EmployeeId + "\t" + f.FirstName + "\t" + f.LastName + "\t" + f.Title + "\t" + f.DOB + "\t" + f.DOJ + "\t" + f.City);
            }
            Console.WriteLine();
            Console.WriteLine();

            //d. Display details of all the employee whose Last Name start with S

            e = from w in emplist
                where w.LastName.StartsWith("S")
                select w;
            foreach (var f in e)
            {
                Console.WriteLine(f.EmployeeId + "\t" + f.FirstName + "\t" + f.LastName + "\t" + f.Title + "\t" + f.DOB + "\t" + f.DOJ + "\t" + f.City);
            }
            Console.WriteLine();
            Console.WriteLine();

            //e. Display a list of all the employee who have joined before 1/1/2015

            e = from w in emplist
                where w.DOJ < new DateTime(1 / 1 / 2015)
                select w;

            foreach (var f in e)
            {
                Console.WriteLine(f.EmployeeId + "\t" + f.FirstName + "\t" + f.LastName + "\t" + f.Title + "\t" + f.DOB + "\t" + f.DOJ + "\t" + f.City);
            }
            Console.WriteLine();
            Console.WriteLine();

            //f.Display a list of all the employee whose date of birth is after 1 / 1 / 1990

            e = from w in emplist
                where w.DOB > new DateTime(1 / 1 / 1990)
                select w;

            foreach (var f in e)
            {
                Console.WriteLine(f.EmployeeId + "\t" + f.FirstName + "\t" + f.LastName + "\t" + f.Title + "\t" + f.DOB + "\t" + f.DOJ + "\t" + f.City);
            }
            Console.WriteLine();
            Console.WriteLine();


            //g. Display a list of all the employee whose designation is Consultant and Associate

            e = emplist.Where(f => f.Title == "Associate");
            foreach (var f in e)
            {
                Console.WriteLine(f.EmployeeId + "\t" + f.FirstName + "\t" + f.LastName + "\t" + f.Title + "\t" + f.DOB + "\t" + f.DOJ + "\t" + f.City);
            }
            Console.WriteLine();
            Console.WriteLine();

            //h. Display total number of employees

            var count = emplist.Count();
            Console.WriteLine("Total Number of Employees are:{0}", count);
            Console.WriteLine();
            Console.WriteLine();

            //i. Display total number of employees belonging to “Chennai”

            var Ch = emplist.Count(x => x.City == "Chennai");
            Console.WriteLine("Total Number of Employees in Chennai are : {0}", Ch);
            Console.WriteLine();
            Console.WriteLine();

            //j. Display highest employee id from the list

            var highest = emplist.Max(x => x.EmployeeId);
            Console.WriteLine("The Highest Employee Id in the Table is: {0} ", highest);
            Console.WriteLine();
            Console.WriteLine();

            //k. Display total number of employee who have joined after 1/1/2015

            var emp = emplist.Count(x => x.DOJ > new DateTime(1 / 1 / 2015));
            Console.WriteLine("Total Number of Employees Joined after 1/1/2015 are : {0} ", emp);
            Console.WriteLine();
            Console.WriteLine();

            //l. Display total number of employee whose designation is not “Associate”

            var ass = emplist.Count(x => x.Title != "Associate");
            Console.WriteLine("Total Number of Employees Other than Associates are:{0}", ass);
            Console.WriteLine();
            Console.WriteLine();

            //m. Display total number of employee based on City

            var ct = from p in emplist
                     group p by p.City into g
                     select new { City = g.Key, ProductCount = g.Count() };
            Console.WriteLine("City\t   No.of Employees");
            foreach (var group in ct)
            {
                Console.WriteLine(group.City + "\t\t" + group.ProductCount);
            }
            Console.WriteLine();
            Console.WriteLine();

            //n. Display total number of employee based on city and title

            var cc = from p in emplist
                     group p by p.City into g
                     select new { City = g.Key, ProductCount = g.Count() };
            Console.WriteLine("City\t   No.of Employees");
            foreach (var group in cc)
            {
                Console.WriteLine(group.City + "\t\t" + group.ProductCount);
            }
            Console.WriteLine();
            Console.WriteLine();

            //n. Display total number of employee based on city and title


            var tt = from t in emplist
                     group t by t.Title into g
                     select new { Title = g.Key, ProductCount = g.Count() };
            Console.WriteLine("Ttile\t   No.of Employees");
            foreach (var group in tt)
            {
                Console.WriteLine(group.Title + "\t\t" + group.ProductCount);
            }
            Console.WriteLine();
            Console.WriteLine();

            //o. Display total number of employee who is youngest in the list

            var m1 = emplist.Max(x => x.DOB);
            var m2 = emplist.Where(x => x.DOB == m1);

            foreach (var item in m2)
            {
                Console.WriteLine("The youngest Employee Of All the Employees is : {0} {1}", item.FirstName, item.LastName);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
