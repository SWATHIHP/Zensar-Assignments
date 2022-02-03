using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthConsolePrj
{
    class Shape
    {
        protected float R, L, B;
        public virtual float Area()//base class allows redefining the area in the child class using the key "virtual"
        {
            return 3.14f * R * R;//parent has written the coding to find area of a circle
        }
        public virtual float Circumference()
        {
            return 2*3.14f*R;
        }
    }
    class Rectangle : Shape
    {
        public void GetLB()
        {
            Console.Write("Enter Length : ");
            L=float.Parse(Console.ReadLine());
            Console.Write("Enter Breadth : ");
            B=Convert.ToSingle(Console.ReadLine());     
        }
        public override float Area()
        {
            return (L*B);
        }
        public override float Circumference()
        {
            Console.WriteLine(base.Circumference());
            return 2*(L+B);//formula for finding perimeter/circumference
        }
    }
    class Circle : Shape
    {
        public void GetRadius()
        {
            Console.Write("Enter Radius : ");
            R=float.Parse(Console.ReadLine());  
        }
        public override float Area()
        {
            Console.WriteLine(base.Area());
            return 3 * R * R;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.GetLB();
            //float area=r.Area();
            Console.WriteLine("Area of Rectangle {0}", r.Area());
            Console.WriteLine("Perimeter of Rectangle {0}: ",r.Circumference());
            Circle c = new Circle();
            c.GetRadius();
           // c.Area();
            //c.Circumference();
            //r.Perimeter();
            
            float area_of_circle=c.Area();
            Console.WriteLine("Area of circle is{0}: ",area_of_circle);
            Console.WriteLine("Circumference of Rectangle {0}", c.Circumference());

            Console.Read();
        }
    }
}
