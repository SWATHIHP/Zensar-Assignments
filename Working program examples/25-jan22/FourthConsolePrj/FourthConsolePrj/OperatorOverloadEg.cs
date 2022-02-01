using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthConsolePrj
{
    class Distance
    {
        int dist;
        //float num;

        //property
        public int Dist
        {
            get { return dist; }
            set { dist = value; }
        }

        //operator + overloading

        public static Distance operator +(Distance d1,Distance d2)
        {
            Distance temp = new Distance();
            temp.dist = d1.dist + d2.dist;
           // temp.num = d1.num + d2.num;
            return temp;
        }
    }
    class OperatorOverloadEg
    {
        static void Main()
        {
            Distance d1 = new Distance();
            Distance d2 = new Distance();
            d1.Dist = 10;
            d2.Dist = 20;
            Distance d3=d1+ d2;
            Console.WriteLine($"The overall Distance is {d3.Dist}");
            Console.Read();
        }
    }
}
