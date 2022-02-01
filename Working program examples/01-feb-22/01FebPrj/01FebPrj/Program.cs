using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01FebPrj
{
    class Program
    {
        delegate void Print(int val);
        static void Main(string[] args)
        {
            //Anonymous Methods
            Print p = delegate (int x) { Console.WriteLine("Inside Anonymous method.Value{0}", x+5); };
            p(100);

           /* Print p1 = new Print(Sample);
            p1(200);
            p1(7555);
            p1(456);//you can call 'sample' function for n number of times
            p(300);
*/
            //Anonymous method can access variables defined in an outer function
            int y = 10;
            Print print = delegate (int w) { w += y; Console.WriteLine("Anonymous method accessing outside variable {0}", w); };
            print(10);//invoking the anonymous method thriugh delegate object
            Console.Read();
        }
        public static void Sample(int z)
        {
            z = z + 100;
            Console.WriteLine("Inside Normal Method");
            Console.WriteLine(z);
            //testfunc();

            Print p = delegate (int x) { Console.WriteLine("Inside Anonymous method.Value{0}", x *2); };
            p(100);
        }
        public  static void testfunc()
        { 
            Console.WriteLine("Inside Testing");
        }
    }
}
