using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Array_Assignment
    {
        class Array_2
        {
            public int[] arr = new int[10];
            public int total = 0;
            public double average;


            public void Ele()
            {
                Console.WriteLine("Enter 10 Subjects Marks: ");
                for (int i = 0; i < 10; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
            }

            public void Avg()
            {
                for (int i = 0; i < 10; i++)
                {
                    total = total + arr[i];
                }
                Console.WriteLine("Total of 10 Subjects Marks is : {0}.", total);

                average = Queryable.Average(arr.AsQueryable());
                Console.WriteLine("Average of 10 Subjects Marks is : {0}", average);

            }

            public void MinMax()
            {
                Array.Sort(arr);
                Console.WriteLine("Minimum value is : {0}, Maximum value is : {1}.", arr[0], arr[9]);
            }

            public void AscDsc()
            {
                Array.Sort(arr);
                Console.WriteLine("Marks in Ascending Order: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("\t" + arr[i]);
                }

                Array.Reverse(arr);
                Console.WriteLine("\nMarks in Descending Order: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("\t" + arr[i]);
                }
                Console.WriteLine("\n");
            }

            static void Main(string[] args)
            {
                Array_2 assign = new Array_2();
                assign.Ele();
                assign.Avg();
                assign.MinMax();
                assign.AscDsc();
            Console.ReadLine();
            }
        }
    }

    

