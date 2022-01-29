//4.Write a program which accepts marks of 5 students for C#,HTML and Sql (3 subjects),calculates the average and prints result as passed or failed
//If avg < 50 then failed else passed. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class StudMarks
    {
        static void Main(string[] args)
        {
            int total1,total2,total3,total4,total5;
            double avg1,avg2,avg3,avg4,avg5;
            string name1,name2,name3,name4,name5;          

            //s1
            Console.Write("Input the Name of the Student_1 :");
            name1 = Console.ReadLine();
            Console.Write("Input  the marks of C# : ");
            int cs1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  HTML : ");
            int html1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of SQL : ");
            int sql1 = Convert.ToInt32(Console.ReadLine());
            total1 = cs1 + html1 + sql1;
            avg1 = total1 / 3.0;
            if (avg1 < 50)
                Console.WriteLine("Failed");
            else
                Console.WriteLine("Passed");
            Console.WriteLine("Name of Student1 : {0}", name1);
            Console.WriteLine("Marks in C# : {0} Marks in HTML : {1} Marks in SQL : {2}", cs1, html1, sql1);
            Console.WriteLine("Total Marks of Student_1 = {0} Average of Student_1 = {1}", total1, avg1);


            //s2
            Console.Write("Input the Name of the Student_2 :");
            name2 = Console.ReadLine();
            Console.Write("Input  the marks of C# : ");
            int cs2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  HTML : ");
            int html2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of SQL : ");
            int sql2 = Convert.ToInt32(Console.ReadLine());
            total2 = cs2 + html2 + sql2;
            avg2 = total2 / 3.0;
            if (avg2 < 50)
                Console.WriteLine("Failed");
            else
                Console.WriteLine("Passed");
            Console.WriteLine("Name of Student2 : {0}", name2);
            Console.WriteLine("Marks in C# : {0} Marks in HTML : {1} Marks in SQL : {2}", cs2, html2, sql2);
            Console.WriteLine("Total Marks of Student_2 = {0} Average of Student_2 = {1}", total2, avg2);


            //s3
            Console.Write("Input the Name of the Student_3 :");
            name3 = Console.ReadLine();
            Console.Write("Input  the marks of C# : ");
            int cs3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  HTML : ");
            int html3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of SQL : ");
            int sql3 = Convert.ToInt32(Console.ReadLine());
            total3 = cs3 + html3 + sql3;
            avg3 = total3 / 3.0;
            if (avg3 < 50)
                Console.WriteLine("Failed");
            else
                Console.WriteLine("Passed");
            Console.WriteLine("Name of Student_3 : {0}", name3);
            Console.WriteLine("Marks in C# : {0} Marks in HTML : {1} Marks in SQL : {2}", cs3, html3, sql3);
            Console.WriteLine("Total Marks of Student_3 = {0} Average of Student_3 = {1}", total3, avg3);


            //s4
            Console.Write("Input the Name of the Student_4 :");
            name4 = Console.ReadLine();
            Console.Write("Input  the marks of C# : ");
            int cs4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  HTML : ");
            int html4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of SQL : ");
            int sql4 = Convert.ToInt32(Console.ReadLine());
            total4 = cs4 + html4 + sql4;
            avg4 = total4 / 3.0;
            if (avg4 < 50)
                Console.WriteLine("Failed");
            else
                Console.WriteLine("Passed");
            Console.WriteLine("Name of Student_4 : {0}", name4);
            Console.WriteLine("Marks in C# : {0} Marks in HTML : {1} Marks in SQL : {2}", cs4, html4, sql4);
            Console.WriteLine("Total Marks of Student_4 = {0} Average of Student_4 = {1}", total4, avg4);


            //s5
            Console.Write("Input the Name of the Student_5 :");
            name5 = Console.ReadLine();

            Console.Write("Input  the marks of C# : ");
            int cs5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  HTML : ");
            int html5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of SQL : ");
            int sql5 = Convert.ToInt32(Console.ReadLine());
            total5 = cs5 + html5 + sql5;
            avg5 = total5 / 3.0;
            if (avg5 < 50)
                Console.WriteLine("Failed");
            else
                Console.WriteLine("Passed");
            Console.WriteLine("Name of Student_5 : {0}", name5);
            Console.WriteLine("Marks in C# : {0} Marks in HTML : {1} Marks in SQL : {2}", cs5, html5, sql5);
            Console.WriteLine("Total Marks of Student_5 = {0} Average of Student_5 = {1}", total5, avg5);
            Console.ReadLine();
        }
    }
}
