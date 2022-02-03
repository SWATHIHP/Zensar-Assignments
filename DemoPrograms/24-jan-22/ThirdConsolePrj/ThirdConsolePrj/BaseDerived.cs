using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsolePrj
{
    class ParentClass
    {
        public int parentdata;
        internal Parentclass(int data)
        {
            parentdata = data;
        }
    }
    class Child:Parentclass
    {
        public int childdata;

        //one parameter constructor that initializes both parent data as well as childdata
        internal Child(int cdata):base(cdata)
        {
            childdata = cdata;
        }
        public Child(int cdata,int pdata):base(pdata)
        {
            childdata=cdata;
        }
    }
    class BaseDerived
    {
        static void Main()
        {
            Child child = new Child(20,30);
            Console.WriteLine("Childdata is : "+child.childdata);
            Console.WriteLine("Parentdata is : " + child.parentdata);
            Console.ReadLine();
        }
    }
}
