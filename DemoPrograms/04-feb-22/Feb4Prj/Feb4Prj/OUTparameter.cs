using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb4Prj
{
    class OUTparameter
    {
        static void Main()
        {
/*            //out parameters before C# 7.0
            string ename, gender, department;
            long salary;
            GetEmp(out ename, out gender, out department, out salary);
            Console.WriteLine($"{ ename},{ gender},{ department},{ salary}");
         */   

/*

            //with C# 7.0 rewite the above code as below
            GetEmp(out string ename,out string gender,out string department, out long salary);
            Console.WriteLine($"{ ename},{ gender},{ department},{ salary}");

*/
            //if we want to ignore "output" parameter (we use '_' )
            GetEmp(out var ename, out var gender, out _, out var salary);
            Console.WriteLine($"{ ename},{ gender},{ salary}");


            Console.Read();
        }
        static void GetEmp(out string ename,out string gender,out string department,out long salary)
        {
            ename = "Kim Namjoon";
            gender = "Male";
            department = "HR";
            salary = 85000;
        }
    }
}
