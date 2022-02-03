using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb3Prj
{
    class class1 { }
    class class2 { }

    class Equality1
    {
        public static void Test(Object obj)
        {
            class1 a;
            class2 b;
            if(obj is class1)
            {
                Console.WriteLine("Obj is Class1");
                a=(class1)obj;
            }
            else if(obj is class2)
            {
                Console.WriteLine("Obj is Class2");
                b=(class2)obj;
            }
            else if(obj is List<int>)
            {
                Console.WriteLine("It's a list");
            }
            else
            {
                Console.WriteLine("Obj is neither Class1 nor Class2");
            }
        }
        static void Main()
        {
           /* class1 c1= new class1();
            class2 c2= new class2();
            Test(c1);
            Test(c2);
            Test("Passing string data");
            string s = "Hey";
            Test(s);
            List<int> l = new List<int>();//list object
            Test(l);*/

            Object[] myobject=new Object[5];
            myobject[0]=new class1();
            myobject[1]=new class2();
            myobject[2]="Data String";
            myobject[3] = null;
            myobject[4] = 67;
            for(int i = 0;i<myobject.Length;i++)
            {
                string s=myobject[i] as string;
                Console.Write("{0} : ",i);
                if(s!=null)
                {
                    Console.WriteLine("'"+ s + "'");
                }
                else
                    Console.WriteLine("Not a string");
            }

            Console.Read();
        }
    }
}
