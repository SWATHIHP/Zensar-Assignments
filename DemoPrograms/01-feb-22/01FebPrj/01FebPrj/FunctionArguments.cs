using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01FebPrj
{
    class FunctionArguments
    {
        //default prameters
        public static void StudDetails(string fname,string lname,int age=20,string branch="CSE")
        {
            Console.WriteLine($"Firstname : {fname}");
            Console.WriteLine($"Lastname : {lname}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Branch : {branch}");

        }
        //named parameters
        public static void Sdetails(string fname,string lname,int age,string branch)
        {
            Console.WriteLine($"{fname},{lname},{age},{branch}");
        }
        static void Main()
        {
            StudDetails("Park", "Jimin");
            StudDetails("Kim", "Teahyung", 26);
            StudDetails("Jeon", "Jungkok", 24, "CS");

            //calling functions with named parameters
            Sdetails(age: 26, fname: "Min", lname: "Yoongi", branch: "CSE");
            Console.Read();
        }
    }
}
