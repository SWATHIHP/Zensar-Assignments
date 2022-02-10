using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb4Prj
{
    class Iterators
    {
        public static IEnumerable<string > GetList()
        {
            List<string> mylist = new List<string>()
            { "Apples","Mangoes","Strawberies","Oranges" };
            foreach(var items in mylist)
            {
                yield return items;
            }
            
        }
        static void Main()
        {
            IEnumerable<string> elist = GetList();
            foreach(var item in elist)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
