using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_ConsoleDay2
{
    class EmpSample
    {
        //private fields
        int EmpID;
        string Cname;
        string Ename;
        float sal;

        //public props declaration
        public int ReCode
        {
            get { return EmpID; }
            set { EmpID = value; }
        }
        public string CoName
        {
            get { return Cname; }
            set { Cname = value; }
        }
        public void Show()
        {
            Console.WriteLine(EmpID+" "+Ename+" "+Cname+" "+sal);
        }
        static void Main()
        {
            EmpSample eSample = new EmpSample() { Cname="Zensar"};
            eSample.Show();
            EmpSample eSample2 = new EmpSample() { Ename="Swathi",EmpID=65798};
            eSample2.Show();
            Testing.CheckinProperties();
            Console.Read();
        }
        class Testing
        {
            public static void CheckinProperties()
            {
                EmpSample empSample = new EmpSample();
                empSample.ReCode = 65798;
                
                Console.WriteLine(empSample.ReCode);
                


            }
        }
    }
}
