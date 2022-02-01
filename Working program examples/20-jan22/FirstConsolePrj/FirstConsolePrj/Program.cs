using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsolePrj
{
    class Program
    {
        public int Id;
        public string Name;
        DateTime doj;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Id = 5;
            p.Name = "Zensar";
            p.doj = Convert.ToDateTime("04/01/22");
            Program p1 = new Program();
            p1.Id = 10;
            p1.Name = ".Net";
            Console.WriteLine("Id of object P:{0},Name of obj P:{1},DOJ of obj P:{2}" + " ", p.Id, p.Name, p.doj);//{0},{1} - placeholders
            Console.WriteLine("Id of object P" + " " + p1.Id + " " + p1.Name);//concatenation
            display();
            p.TestFunc();
            p1.TestFunc();
            MyClass mc=new MyClass();
            mc.Accept();
            MyClass.Show();
            Console.Read();
        }
        static public void display()
        {
            Console.WriteLine("Hello static");
        }
        public void TestFunc()
        {
            Console.WriteLine("it is a test function, hello public from Obj P");
        }
    }
    class MyClass
    {
        static string empname;
        static int empid;
        public void Accept()
        {
            Console.WriteLine("Please enter your name: ");
            empname = Console.ReadLine();
            Console.WriteLine("Enter your ID: ");
            empid = Convert.ToInt32(Console.ReadLine());
        }
        public static void Show()
        {
            Console.WriteLine("The employee id is:{0} and the name is : {1}", empid, empname);
        }
    }


}
