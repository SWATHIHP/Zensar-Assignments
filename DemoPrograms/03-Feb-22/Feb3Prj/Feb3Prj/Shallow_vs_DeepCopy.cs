using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb3Prj
{
    class Person
    {
        public int Age;
        public PersonDescription desc;//composition

        //constructor
        public Person(int a,string fn,string ln)
        {
            Age = a;
            desc=new PersonDescription(fn,ln);
        }

        //function
        public object ShallowCopy()
        {

            return this.MemberwiseClone();
        }
        public Person DeepCopy()
        {
            Person dcpy = new Person(this.Age,desc.Fname,desc.Lname);
            return dcpy;
        }

    }
    class PersonDescription
    {
        public string Fname;
        public string Lname;

        public PersonDescription(string f,string l)
        {
            this.Fname = f;
            this.Lname = l;
        }
    }
    class Shallow_vs_DeepCopy
    {
        static void Main()
        {
            Person p1 = new Person(44, "Park", "Jimin");

            //invoking Shallowcopy
            Person p2=(Person)p1.ShallowCopy();//(Person) is type casting
 /*           Console.WriteLine(p1.Age+" "+p1.desc.Lname);
            Console.WriteLine(p2.Age + " " + p2.desc.Lname);
            p2.desc.Lname = "JinYoung";
            Console.WriteLine(p1.Age + " " + p1.desc.Lname);
            Console.WriteLine(p2.Age + " " + p2.desc.Lname);
*/
            //invoking Deepcopy
            Person p3=p1.DeepCopy();
            Console.WriteLine(p1.desc.Lname);
            Console.WriteLine(p3.desc.Lname);
            p3.desc.Lname = "Yoongi";
            Console.WriteLine(p1.desc.Lname);
            Console.WriteLine(p3.desc.Lname);
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p3.GetHashCode());
            p2 = p1;
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());

            Console.Read();
        }
    }
}
