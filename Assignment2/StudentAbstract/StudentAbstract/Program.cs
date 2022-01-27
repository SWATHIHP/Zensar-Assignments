/*3.Create an Abstract class Student with  Name, StudentId, Grade as members and also an abstract method Boolean Ispassed(grade) which takes grade as an input and checks whether student passed the course or not.  

Create 2 Sub classes Undergraduate and Graduate that inherits all members of the student and overrides Ispassed() method 

For the UnderGrad class, if the grade is above 70.0, then isPassed returns true, otherwise it returns false. For the Grad class, if the grade is above 80.0, then isPassed returns true, otherwise returns false.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAbstract
{
    abstract class Student
    {
        public string name;
        public int StudentId;
        public double grade;

        //declare an abstract method
        abstract public Boolean Ispassed();
       
    }
    class Undergraduate : Student
    {
        public void GetGrade()
        {
            Console.Write("Enter Student Name: ");
            name =Console.ReadLine();
            Console.Write("Enter Student ID: ");
            StudentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Grade:");
            grade = Convert.ToDouble(Console.ReadLine());
        }

        public override bool Ispassed()
        {
            // throw new NotImplementedException();
            if (grade > 70.0)
                return true;
            return false;
        
        }
    }
    class Graduate : Student
    {
        public override bool Ispassed( )
        {
            // throw new NotImplementedException();
            if (grade > 80.0)
                return true;
            else
                return false;

        }
    }
    class AbstractStud
    {
        public static void Display(Student s)
        {
            Console.WriteLine("--------------------RESULT------------------");
            Console.WriteLine("Name : {0}",s.name);
            Console.WriteLine("Student ID : {0}",s.StudentId);
            Console.WriteLine("Grade : {0}",s.grade);
        }
        static void Main()
        {
           
            Undergraduate ug=new Undergraduate();
            ug.GetGrade();
            Display(ug);
            Console.WriteLine("Undergraduate : "+ug.Ispassed());
            Graduate g = new Graduate();
            Console.WriteLine("Graduate : "+g.Ispassed());
            
            Console.ReadKey();

        }
    }
}

