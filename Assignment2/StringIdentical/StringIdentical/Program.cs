//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIdentical
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the first string: ");
			string str1 = Console.ReadLine();
			Console.Write("Enter the second string :");
			string str2 = Console.ReadLine();

			Console.WriteLine("Are both strings same: ");

			if (str1.Equals(str2) == true)
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}
			Console.ReadLine();
		}
	}

}