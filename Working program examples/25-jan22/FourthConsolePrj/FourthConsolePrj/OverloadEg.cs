using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthConsolePrj
{
    class OverloadEg
    {
        public static void Swap(int num1,int num2)
        {
            Console.WriteLine("Swap with 2 int arguments");
            num1 = num2 + num2;
            num2 = num1 - num2;
            num1= num1 - num2;

            //or
            //int temp = num1;
            //num1 = temp;
            //temp = num2;
            Console.WriteLine($"Swapping of 2 intergers,num1={num1},num2={num2}");
        }
        public static void Swap(char c1,char c2)
        {
            char temp = ' ';
            temp = c1;
            c1 = c2;
            c2 = temp;
            Console.WriteLine($"Swapping of characters,c1={c1} and c2={c2}");
        }
        static void Main()
        {
            Swap(5,4);//pls jump to line num - 11 or 12
            Console.WriteLine("--------------------------");
            Swap('a', 'b');//pls jump to line num - 26


            Console.WriteLine("=============over riding============");
            Shapes s = new Shapes();
            s.Message("Shape base");
            s = new Square();//co-variance
            s.Message("Squares Message");
            s=new Triangle();
            s.Message("Triangles Message");
            s=new Hexagon();
            s.Message("Hexagon has 6 sides");
            Console.Read();
        }
    }
    class Shapes
    {
        public virtual void Message(string s)
        {
            Console.WriteLine($"Message from shapes class{s}");
        }
    }
    class Square : Shapes
    {
        public override void Message(string s)
        {
           // base.Message(s);
            Console.WriteLine($"Message fron square clss {s}");
        }
    }
    class Triangle : Shapes
    {
        public override void Message(string s)
        {
            //base.Message(s);
            Console.WriteLine($"Message from triangle class {s}");
        }
    }
    class Hexagon:Shapes
    {
        public override void Message(string s)
        {
           // base.Message(s);
            Console.WriteLine($"Hexagon class messaged {s}");
        }
    }
}
