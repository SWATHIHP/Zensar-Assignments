using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan28ConsolePrj
{
    class ListEg
    {
        public static void Main()
        {
            //generic way of declaring objects
            List<int> mylist = new List<int>();
            mylist.Add(356);
            mylist.Add(46);
            mylist.Add(98);

            foreach(int i in mylist)
            {
                Console.WriteLine(i);
            }
            
            //hashtables of collections are equal to Dictionary of Generics
            Dictionary<int,string> mydict = new Dictionary<int,string>();
            mydict.Add(1, "BTS");
            mydict.Add(2, "GOT7");
            mydict.Add(5, "Blackpink");
            mydict.Add(9, "Straykids");
            mydict.Add(3, "MonstaX");
            mydict.Add(7, "Twice");
            mydict.Add(4, "TxT");
            foreach(int a in mydict.Keys)
            {
                Console.WriteLine(a);
            }
            foreach(string s in mydict.Values)
            {
                Console.WriteLine(s);
            }

            //inorder to get both keys and values, use key-value pair
            foreach(KeyValuePair<int,string> kvp in mydict)
            {
                Console.Write(kvp.Key);
                Console.Write(kvp.Value);
                Console.WriteLine();
            }

            Console.Read(); 

        }
    }
}
