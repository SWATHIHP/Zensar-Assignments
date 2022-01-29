//1. 	Write a  Program to assign integer to an array  and then print the following
//a.	 Average value of Array elements
//b.	Minimum and Maximum value in an array 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Array_1
    {
        public static void Main()
        {
            //int[] arr = { 1, 2, 6, 2, 18 };

            int[] arr = new int[5] { 99, 95, 93, 89, 87 };
            int  max, min, n;
            // size of the array
            n = 5;

            int i = 0;
            int sum = 0;
            float average = 0.0F;

            for (; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            average = (float)sum / arr.Length;
            Console.WriteLine("Average of Array elements: " + average);
            
            max = arr[0];
            min = arr[0];
            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Maximum element = {0}", max);
            Console.WriteLine("Minimum element = {0}", min);
            Console.ReadLine();
        }
        
        
    }
}
