//2.	Write a program in C# to accept a word from the user and display the reverse of it. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, str1 = "";
            int i, l;
            Console.Write("Input  A String : ");
            str = Console.ReadLine();

            l = str.Length - 1;
            for (i = l; i >= 0; i--)
            {

                str1 = str1 + str[i];


            }

            Console.WriteLine("The string in Reverse  Order Is : {0}", str1);
            Console.ReadKey();
        }
    }
}
