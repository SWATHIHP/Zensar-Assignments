using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_ConsoleDay2
{
    class StudentSample
    {
        //private fields
        int RollNo;
        string SName { get; set; }//automatic properties
       
        public float Marks { get; }


        public int sem { get; set; }


        //public properties declaration
        public int RegCode//readonly property
        {
            get { return RollNo; }
            set { RollNo = value; }
        }
        
        
        public void Show()
        {
            Console.WriteLine(RollNo+" "+SName+" "+Marks);
        }
        static void Main()
        {
            StudentSample s1 = new StudentSample();//invoking default constructor provided by frame
            s1.Show();
            //StudentSample s2 = new StudentSample() { Marks=78.0f,SName="Alex",RollNo=5};
            StudentSample s2= new StudentSample() { RollNo=666,SName="Brent",sem=8};
            s2.Show();
            Tester.CheckingProperties();
            Console.ReadLine();
        }
       
    }
    class Tester
    {
        public static void CheckingProperties()
        {
            StudentSample studsample = new StudentSample();
            studsample.RegCode = 215;//set
            //studsample.SName = "Alan";

           // Console.WriteLine(studsample.SName);
            Console.WriteLine(studsample.RegCode);//get
            Console.WriteLine(studsample.Marks);
        }
    }
}
