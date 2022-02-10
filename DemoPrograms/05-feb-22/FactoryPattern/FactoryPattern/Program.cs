using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface Shape
    {
        void draw();
    }
    public class Rectangle:Shape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Square");
        }
    }
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Cicle");
        }
    }
    public class ShapeFactory
    {
        public Shape GetShape(string shapetype)
        {
            if(shapetype.Equals("Rectangle"))
            {
                return new Rectangle();
            }
            else if(shapetype.Equals("Square"))
            {
                return new Square();
            }
            else if (shapetype.Equals("Circle"))
            {
                return new Circle();
            }
            else
                return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory sf=new ShapeFactory();
            Shape s = sf.GetShape("Rectangle");
            s.draw();
             s = sf.GetShape("Square");
            s.draw();
            s = sf.GetShape("Circle");
            s.draw();


            Console.ReadLine();
        }
    }
}
