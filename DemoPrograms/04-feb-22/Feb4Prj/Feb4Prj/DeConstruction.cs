using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb4Prj
{
    class DeConstruction
    {
        static (string ,double ,string ,string)GetEmpDetails(long Eid)
        {
            string Ename = "Taehyung";
            double  Salary = 45000;
            string Gender = "Male";
            string Dept = "IT";
            return (Ename, Salary, Gender, Dept);
        }
        static void Main()
        {
           /* var Edetails = GetEmpDetails(111);
            //de-construction(one way}
            var name = Edetails.Item1;
            double Sal= Edetails.Item2;
            var gender = Edetails.Item3;
            var dept = Edetails.Item4;
            Console.WriteLine($"The employee deails are :  {name}, {Sal}, {gender}, {dept}");
*/
            //another way to deconstrution
            (string name, double sal , string gender , string dept) = GetEmpDetails(111);

            //third way to deconstruct(use the variable names as that of the as that of the method is returnong values)
            var (Ename, Salary, Gender, Dept) = GetEmpDetails(111);

            //dictionary Initializers before C# 6.0
            Dictionary<int, string> emp = new Dictionary<int, string>()
            {
                {1,"Heoseok" },
                { 2,"Kimseok"},
                {3,"Namjoon"},
                {4,"Yoongi" }
            };

            //with C# 6.0
            Dictionary<string, string> emp1 = new Dictionary<string, string>()
            {
                ["Jinyoung"] = "E222",
                ["Jackson"] = "E226",
                ["Jaebeom"] = "E228"
            };

            Console.Read();
        }
    }
}
