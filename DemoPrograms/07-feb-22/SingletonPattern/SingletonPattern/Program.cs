using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonObject
    {
        //static object of the class is getting created through a private contructor
        private static SingletonObject sobj=new SingletonObject();

        //private constructor
        private SingletonObject() { }
        public static SingletonObject getObject()
        {
            return sobj;
        }
        public void ShowMessage()
        {
            Console.WriteLine("Hello world of singleton!!");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //getting the singleton object through the method of the class not the constructor
            SingletonObject s = SingletonObject.getObject();

            //call the other public method
            s.ShowMessage();
            Console.Read();

        }
    }
}
