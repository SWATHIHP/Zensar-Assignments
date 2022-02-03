using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsolePrj
{
    class Empolyee
    {
        int EmpId;
        string Ename;
        float ESal;

        public void GetEmp()
        {
            Console.WriteLine("Enter emp id, name and sal: ");
            EmpId = Convert.ToInt32(Console.ReadLine());
            Ename = Console.ReadLine();
            ESal = Convert.ToSingle(Console.ReadLine());
        }

        public void ShowEmp()
        {
            Console.WriteLine(" Emp details, Id={0}, Name={1},Salary={2}", EmpId, Ename, ESal);
        }

        public static void Main()
        {
            Empolyee emp = new Empolyee();
            emp.GetEmp();
            emp.ShowEmp();
        }
    }
}
