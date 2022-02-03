using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan31Prj
{
    public delegate void MultiDelegate();
    public delegate int MultiRetDelegate(int n);
    class MultiDelegates
    {

        public static void Method1()
        {
            Console.WriteLine("Method1 invoked");
        }
        public  static void Method2()
        {
            Console.WriteLine("Method2 invoked");
        }
        public static void Method3()
        {
            Console.WriteLine("Method3 invoked");
        }
        class TestMultiRetDeligate
        {
            static int p;
            public int Square(int x)
            {
                p = x * x;
                return p;
            }
            public int Tripple(int r)
            {
                p=r* r*r;
                return p;
            }
        }

        static void Main()
        {
           /* MultiDelegate m1, m2, m3, m4;
            m1= new MultiDelegate(Method1);
            m2= new MultiDelegate(Method2);
            m3= new MultiDelegate(Method3);
            m4 = m1 + m2 + m3;//one way of multicasting
           */

            MultiDelegate m1 = new MultiDelegate(Method1);
            m1 += Method2;
            m1 += Method3;//second way of mutlicasting
            m1();
            Console.WriteLine("--------------------------------------------");
            m1-=Method2;//removing one reference
            m1();
            Console.WriteLine("========================Multicast with return type============================");
            TestMultiRetDeligate tmd=new TestMultiRetDeligate();//class obj created
            MultiRetDelegate mrdelegate = new MultiRetDelegate(tmd.Square);
            mrdelegate +=tmd.Tripple;
            int retval = mrdelegate(5);
            Console.WriteLine(retval);


            Console.Read();
        }
    }
}
