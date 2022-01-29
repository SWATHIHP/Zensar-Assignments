//3. Create a program, which accepts 3 numbers as input from the user and prints the largest and smallest of 3 numbers.
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class SmallestOf3
    {
        //program, which accepts 3 numbers as input from the user and prints the largest and smallest of 3 numbers
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            //smallest

            if (num1 < num2)
            {
                if (num1 < num3)
                {
                    Console.WriteLine("Number {0} is the smallest among three.",num1);
                }
                else
                {
                    Console.WriteLine("Number {0} is the smallest among three.",num3);
                }
            }
            else if (num2 < num3)
                Console.WriteLine("Number {0} is the smallest among three.",num2);
            else
                Console.WriteLine("Number {0} is the smallest among three.",num3);
          
            //largest

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Number {0} is the largest among three.",num1);
                }
                else
                {
                    Console.WriteLine("Number {0} is the largest among three.",num3);
                }
            }
            else if (num2 > num3)
                Console.WriteLine("Number {0} is the largtest among three.",num2);
            else
                Console.WriteLine("Number {0} is the largest among three.",num3);
            Console.ReadLine(); 
        }
    }

}

