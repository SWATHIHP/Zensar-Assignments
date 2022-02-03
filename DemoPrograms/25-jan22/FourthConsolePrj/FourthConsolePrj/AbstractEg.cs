using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthConsolePrj
{
    abstract class Shapeclass
    {
        //declare an abstract method
        abstract public int Area();

        public void Message()//non-abstract method with body/definition
        {
            Console.WriteLine("Simple Message");
        }

    }
    class Squares : Shapeclass
    {
        int side = 0;

        //contructor
        public Squares(int n)
        {
            side = n;
        }

        //implementing the abstract method
        public override int Area()
        {
            return side*side;
        }
    }
    class AbstractEg
    {
        static void Main()
        {
            Shapeclass sc=new Squares(7);

            // Squares sq=new Squares(8);//prints 64
            //Console.WriteLine( sq.Area());
            Console.WriteLine(sc.Area());// prints 49
            Console.ReadKey();  

        }
    }
}
