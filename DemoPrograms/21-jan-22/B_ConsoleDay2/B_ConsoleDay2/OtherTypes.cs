using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_ConsoleDay2
{
    class Student
    {
        public int marks1;
        public int marks2;
    }
    class OtherTypes
    {
        enum Days {  Sun,Mon,Tue, Wed, Thur,Fri,Sat}
        
    static void Main()
    {
        Student s1 = new Student();
        s1.marks1 = 85;
        s1.marks2 = 45;
        Console.WriteLine(s1.marks1 + s1.marks2);

        Student s2 = new Student();
        s2 = s1;
        Console.WriteLine(s2.marks1 + s2.marks2);

        s1.marks1 = 77;
        s1.marks2 = 35;
        Console.WriteLine("After reassigning s1...");
        Console.WriteLine(s1.marks1 + s1.marks2);
        Console.WriteLine(s2.marks1 + s2.marks2);
        int weekstart = (int)Days.Mon;
        int weekend = (int)Days.Fri;
        Console.WriteLine("Weekstart: {0} and Weekend: {1}",weekstart,weekend);
        Console.ReadKey();
    }
}
}
