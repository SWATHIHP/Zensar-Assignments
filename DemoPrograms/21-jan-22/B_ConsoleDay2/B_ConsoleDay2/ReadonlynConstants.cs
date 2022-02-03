using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_ConsoleDay2
{
    class ReadonlynConstants
    {
        public readonly int myvar1;
        public readonly int myvar2;
        public int data = 45;
        public const float PI = 9.99f;
        static int num = 3;

        internal ReadonlynConstants(int a,int b)
        {
            myvar1 = a;
            myvar2 = b;
            data = 99;
            num = 88;
            Console.WriteLine("Displaying value of myvar1:{0}, myvar2:{1}, data: {2} and Number:{3}", myvar1,myvar2,data,num);

        }
        static void Main()
        {
            ReadonlynConstants rc = new ReadonlynConstants(100,200);
            ReadonlynConstants rc1 = new ReadonlynConstants(300, 30);
            rc1.data = 76;
            num = 77;
            Console.WriteLine(num);
            Console.Read();
        }

    }
}
