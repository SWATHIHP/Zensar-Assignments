using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class OddEven
    {
        //Accept a number from the user and display whether the given number is an odd number or even number
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number to check whether it is odd or even : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine(+num+" is Even Number");
            }
            else
                Console.WriteLine(+num+" is Odd Number");
            Console.ReadLine();
        }
    }
}
