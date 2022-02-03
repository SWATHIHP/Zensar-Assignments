using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb2Prj
{
    class Student
    {
        public int StudId;
        public string SName;

    }
    class Initializers
    {
        static void Main()
        {
            List<Student> Studlist = new List<Student>()
            {
                new Student() { StudId = 008, SName = "Hobarang" },
                new Student() { StudId = 004, SName = "Namjoonie" },
                new Student() { StudId = 002, SName = "Kookilet" },
                null
            };
            var div = Divide(10, 0);
        }
        public static double Divide(int x,int y)
        {
            return y!=0 ? x / y : throw new DivideByZeroException();
        }
    }
}
    

