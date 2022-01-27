using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    
    class Array_2
    {
        public static void Main()
        {
            int[] arr1 = new int[10];
            int n, i, j, tmp, min, max;
            //int total=0;
            //int size=arr1.Length;
            //float  avg = 0.0f;
            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} Marks in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Marks {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            //total and avg
            
            int total = 0;
            float avg = 0.0F;

            //average = (float)sum / arr.Length;
            for (i = 0; i < arr1.Length; i++)
            {
                total += arr1[i];
            }
            avg = total / arr1.Length;
            Console.WriteLine("The Total marks is : " + total);
            Console.WriteLine("The Average marks is : " + avg);

            //min and max
            max =arr1[0];
            min = arr1[0];
            for (i = 1; i < n; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }
                if (arr1[i] < min)
                {
                    min = arr1[i];
                }
            }
            Console.WriteLine("Maximum Marks = {0}", max);
            Console.WriteLine("Minimum Marks = {0}", min);


            //ascending
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.WriteLine("Marks of array in sorted ascending order:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0}  ", arr1[i]);
            }
            

            //descending
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] < arr1[j])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }

            Console.WriteLine("Marks of the array in sorted descending order:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0}  ", arr1[i]);
            }
            Console.ReadLine();
        }
    }
    
}
