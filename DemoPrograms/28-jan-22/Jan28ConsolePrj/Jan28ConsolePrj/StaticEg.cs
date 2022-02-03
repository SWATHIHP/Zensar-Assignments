using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan28ConsolePrj
{
    class StaticEg
    {
        //let us declare and initialize static data member
        private static int Myval1 = 5;

        //property of static member
        public static int value
        {
            get { return Myval1; }
        }
        public static void PrintVal()
        {
            Console.WriteLine("Static Class.val1" + " " + Myval1);
        }

    }
    class StaticEg2
    {
        private static int val1;

        //static constructor
        static StaticEg2()
        {
            if (StaticEg2.val1 < 10)
            {
                val1 = 25;
            }
            else
            {
                val1 = 99;
            }
            Console.WriteLine("Static Constructor foe class named staticEg2 called..");
        }
        public static void Print()
        {
            Console.WriteLine("StaticEg2 Class.val1" + " " + val1);
        }

        static void Main()
        {
            StaticEg.PrintVal();
            Print();
            Console.Read();
        }
    }
}

