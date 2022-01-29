/*1.Write a program in C# to accept the name of the user and greet the user as:
	“Hi! username 
	Welcome to the world of C#”﻿*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class GreetUser
    {
        static void Main(string[] args)
        {
            Console.Write("Enter username : ");
            string un = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hi! " + un);
            Console.WriteLine("Welcome to the world of C#");
            Console.ReadLine();
        }
    }
}
