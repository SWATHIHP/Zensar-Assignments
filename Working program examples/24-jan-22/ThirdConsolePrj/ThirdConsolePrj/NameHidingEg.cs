using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsolePrj
{
    class Vehicle
    {
        public int engine = 0;

        public void MethodDrive(string s)
        {
            Console.WriteLine("Message from base class {0}",s);
        }
    }
    class Car : Vehicle
    {

        //name hiding(field hiding)
        //redeclaring a member/field in the derived class that is already declared in the base class 
        new int engine;

        public Car(int eng)
        {
            engine = eng;
            base.engine = eng;//initializing the base class field is optional
        }
        public Car(int eng1, int eng2)
        {
            engine = eng1;
            base.engine = eng2;
        }

        public new void MethodDrive(string str)
        {
            Console.WriteLine("Method from Child class {0}",str);
            //Console.WriteLine("Message of base from child",base.);
        }
        public void ShowEngineDetails()
        {
            Console.WriteLine("Engine value in the base class:{0}",base.engine);
            Console.WriteLine("Engine value in the child class:{0}", engine);
        }
    }

    class NameHidingEg
    {
        static void Main()
        {
            Car car = new Car(2, 5);
            car.ShowEngineDetails();
            car.MethodDrive("Learning Hiding");
            Vehicle vehicle = new Vehicle();
            vehicle.MethodDrive("Learning to drive a vehicle");
            Console.ReadLine();
        }
    }
}
