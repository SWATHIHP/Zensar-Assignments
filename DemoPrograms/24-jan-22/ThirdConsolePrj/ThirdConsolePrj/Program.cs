using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsolePrj
{

    //multilevel inheritance
    class Student
    {
        private string RollNo;
        string name;
        string cls;

        internal Student()//parameter less constructor that matches default constructor signature
        {
            Console.WriteLine("Hi Student class here");
        }



        public void GetData()
        {
            Console.WriteLine("Enter RollNo: ");
            RollNo = Console.ReadLine();
            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Class:");
            cls = Console.ReadLine();
        }

        public void PutData()
        {
            Console.WriteLine("Name of the Student = " + name);
            Console.WriteLine("RollNo = " + RollNo);
            Console.WriteLine("Class = " + cls);
        }
    }

    class Marks : Student
    {

        //marks is devived from student class:marks is a child class of student class
        protected int[] a = new int[5];

        public void GetMarks()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter Subject {0} Marks:", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void PutMarks()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Marks in subject {0} : {1}", i + 1, a[i]);
            }
        }

        class Result : Marks
        {
            int TotalMarks = 0;
            public void GetResult()
            {
                for (int i = 0; i < a.Length; i++)
                {
                    TotalMarks = TotalMarks + a[i];
                }
            }
            public void DisplayResult()
            {
                Console.WriteLine("-----------------RESULT----------------");
                PutData();
                PutMarks();
                Console.WriteLine("Total Marks = "+TotalMarks);

            }
            //destructor
            ~Result()
            {
                Console.WriteLine("Bye from Resulst");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Result result = new Result();
                result.GetData();
                result.GetMarks();
                result.GetResult();
                result.DisplayResult();
                result = null;
                GC.Collect();//garbage collection
                Console.Read();
            }
        }
    }
}
