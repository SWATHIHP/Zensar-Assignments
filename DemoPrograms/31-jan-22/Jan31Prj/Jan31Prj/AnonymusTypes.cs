using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan31Prj
{
    class AnonymusTypes
    {
        static void Main()
        {
            var Mytype = new
            {
                data1 = "CSharp",
                data2 = 2,
                data3 = true
            };

            //lamba expressions
            List<int> numbers = new List<int>() { 54,98,345,09,88,23,35,13,34};
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
            //using lamda finding the square of each element in the collection
            //collection method input
            var square = numbers.Select(z => z * z);

            Console.WriteLine("Squares of the ollection..!");
            foreach(var v in square)
            {
                Console.WriteLine("{0}",v);
            }


            //find all the numbers in the list that are divisible by 3
            List<int> divby3 = numbers.FindAll(y => (y % 3) == 0);
            foreach(var c in divby3)
            {
                Console.WriteLine("{0}", c);
            }

            Console.WriteLine(Mytype.ToString());
            Console.Read();
        }
    }
}
