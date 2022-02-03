using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAssgnmnt
{
    class Program
    {
            public const int ToolFare = 500;
            static void Main(string[] args)
            {
                // int Fare = ToolFare;
                string Cust_Name;
                int Cust_Age;
                Console.WriteLine("Please Enter the Name: ");
                Cust_Name = Console.ReadLine();
                Console.WriteLine("Please Enter the Age : ");
                Cust_Age = int.Parse(Console.ReadLine());
                CalculateMethod cm = new CalculateMethod();
                cm.CalculateConcession(Cust_Age, ToolFare);
            }
        
    }
}
