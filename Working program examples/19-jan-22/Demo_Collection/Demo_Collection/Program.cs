using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections;

namespace Demo_Collection
{
    internal class Program
    {
        private static object myhashtable;

        static void Main(string[] args)
        {
            Console.WriteLine("------------------Collections in C#--------------------");

           // ArrayList arrayList
           List<int> MyList = new List<int>();
           /* MyList.Add(10);
            MyList.Add(250);
            MyList.Add(1000);
            MyList.Add(5000);
            MyList.Add(9000);*/

            MyList.Add(14);
            MyList.Add(264);
            MyList.Add(53);
            MyList.Add(463);
            MyList.Add(51);

            Console.WriteLine(MyList.Count);
            Console.WriteLine( MyList.Capacity);
            Console.WriteLine();

          /*  for (int i = 0; i < MyList.Count; i++)
            {
                Console.WriteLine(MyList[i]);
            }*/

            foreach(var item in MyList)
            {
                Console.WriteLine(item);
            }

            MyList.Remove(250);

            foreach (var item in MyList)
            {
                Console.WriteLine(item);
            }

           Console.WriteLine(MyList.IndexOf(1000));
           Console.WriteLine(MyList.IndexOf(9000));
            MyList.Sort();
            //MyList.Reverse();

            List<string> authors=new List<string>(5);
            //List of string

            //Non-Generic type of Collection
            Console.WriteLine("-----------Stack & Queue-------------");
            Stack Mystack=new Stack();
            Mystack.Push(1001);
            Mystack.Push(true);
            Mystack.Push("I am feeling lucky");
            Mystack.Push(3.14256);
            Mystack.Push('Y');

            Console.WriteLine(Mystack.Count);
            foreach (var item in Mystack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Mystack.Pop());

            Console.WriteLine(Mystack.Peek());
            Console.WriteLine(Mystack.Contains(true));
            Console.WriteLine(Mystack.Contains(false));


            Queue MyQueue=new Queue();
            MyQueue.Enqueue("alan");
            MyQueue.Enqueue(true);


            Console.WriteLine("Elements in non-generic queue");

            Queue<string> myStringQueue=new Queue<string>();
            myStringQueue.Enqueue("Randy Pausch");
            myStringQueue.Enqueue("Paulo Cohelo");
            Console.WriteLine("Elements is generic queue");
            foreach (var item in myStringQueue)
            {
                Console.WriteLine(item);
            }

            Hashtable myhashTable=new Hashtable();
            myhashTable.Add(01, "Eva");
            myhashTable.Add(02, "Alex");
            myhashTable.Add(03, "Alan");
            myhashTable.Add(06, "Brent");
            myhashTable.Add(05,false);
            myhashTable.Add(false, false);
            myhashTable.Add(0, 0);
            myhashTable.Add(4, "lexi");
            Console.WriteLine(myhashTable.GetHashCode());

            myhashTable.Remove(0);

            foreach(DictionaryEntry item in myhashTable)
            {
                Console.WriteLine(item.Key +" - "+item.Value);
            }

            HashSet<Int16> intHashset = new HashSet<Int16>();
            intHashset.Add(46);
            intHashset.Add(75);

            foreach(var item in intHashset)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------Dictionary-----------");
            Dictionary<int,string> myCollection = new Dictionary<int,string>();

            myCollection.Add(1, "Namjoon");
            myCollection.Add(2, "Jin");
            myCollection.Add(3, "Suga");
            myCollection.Add(0, "Jhope");
           // myCollection.Add(username, Password);


            foreach(var item in myCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
