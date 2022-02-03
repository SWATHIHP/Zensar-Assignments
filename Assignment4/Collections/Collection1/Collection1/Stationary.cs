using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    class Stationary
    {
            static void Main(string[] args)
            {
                List<int> mylist = new List<int>();
                Console.WriteLine("Enter Number of Elements into List : ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Elements in the List :");
                for (int j = 0; j < number; j++)
                {
                    mylist.Add(int.Parse(Console.ReadLine()));
                }
                mylist.Sort();
                Console.WriteLine("");
                Console.WriteLine("Elements after Adding are : ");
                foreach (int items in mylist)
                {
                    Console.WriteLine(" {0}", items);
                }
            }
        
    }
}
