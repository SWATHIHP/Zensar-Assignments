using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01FebPrj
{
    //generic delegate
    public delegate T Trans<T>(T arg);

    class Utility
    {
        public static void Transform<T>(T[] values, Trans<T> t)
        {
            for(int i=0;i<values.Length;i++)
            {
                values[i]=t(values[i]);//invoking a delegate
            }
        }
    }
    class GenericDelegate
    {
        static void Main()
        {
            int[] val = new int[] { 3, 4, 5 };
            Utility.Transform(val, Square);
            foreach(var i in val)
            {
                Console.Write(i + " ");
            }
            string[] str = { "RM", "Jin", "suga", "Jhope","Jimin","THV","JK" };
            Utility.Transform(str,Showstring);
            foreach(var i in str)
            {
                Console.WriteLine(i+ " ");
            }
            Console.Read();
        }
        static string Showstring(string s)
        {
            return "BTS" + " " + s;
        }

        static int Square(int x)
        {
            return x * x;
        }
    }
}
