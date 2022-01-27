//1.	Write a program in C# to accept a word from the user and display the length of it.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrWordLen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str; 
            int l = 0;
          
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            foreach (char chr in str)
            {
                l += 1;

            }

            Console.Write("Length of the string is : {0}", l);
            Console.Read();
        }
    }
}
