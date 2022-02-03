using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Jan28ConsolePrj
{
    class CollectionsEg1
    {
        static void Main()
        {
          /*  ArrayList al1=new ArrayList();
            al1.Add(10);
            al1.Add("Alex");
            al1.Add(34.554f);
            al1.Add(true);

            al1.Insert(1,"Alan");
            
            foreach(var item in al1)
            {
                Console.WriteLine(item);
            }
            al1.Add(44);
            al1.Add("Jhope");
            al1.Add("Suga");
            al1.Add(false);


            ArrayList al2=new ArrayList();
            al2.Add(22);
            al2.Add(44);
            al2.Add(33);
            al2.Add(11);
            al1.AddRange(al2);

            Console.WriteLine($"Count of elements:{al1.Count} and Capacity is {al1.Capacity}");
            al2.Sort();
            foreach (var a in al2)
            {
                Console.WriteLine(a);
            }
          */


           /* //Hashtable is a collection that stores data wi a key-value pair
            Hashtable ht=new Hashtable();
            ht.Add("E001", "Namjoon");
            ht.Add("E009", "Jin");
            ht.Add("E003", "Suga");
            ht.Add("E004", "Jhope");
            ht.Add("E007", "Jimin");
            ht.Add("E002", "Namjoon");
            ht.Add("E008", null);
            foreach(var ele in ht.Keys)
            {
                Console.WriteLine(ele);
            }
            foreach(var ele in ht.Values)
            {
                Console.WriteLine(ele);
            }
            //inorder to get both key and values, use dictionary entry
            foreach(DictionaryEntry de in ht)
            {
                Console.Write(de.Key);
                Console.Write(de.Value);
                Console.WriteLine();
            }

            //to search for a particular key
            Console.WriteLine("Enter a key to be searched : ");
            string mykey=Console.ReadLine();
            if(ht.ContainsKey(mykey))
                {
                Console.WriteLine(mykey + "=" + ht[mykey]);
            }
            else
            {
                Console.WriteLine(mykey + "=" + "does not exist");
            }

            //to search for a particular value(we cannot find key using value)
            Console.WriteLine("Enter the value to be searched : ");
            string myvalue=Console.ReadLine();
            if(ht.ContainsValue(myvalue))
            {
                Console.WriteLine(myvalue + "" + ht[myvalue]);
            }
            else
            {
                Console.WriteLine(myvalue + "=" + "Does not exist");
            }*/


            //sorted list
            SortedList sl=new SortedList();
            sl.Add("vb", "Visual Basic");
            sl.Add("cs", "CSharp");
            sl.Add("ora", "Oracle");
            foreach(var ele in sl.Keys)
            {
                Console.WriteLine(ele);
            }


            //stack
            Stack st=new Stack();
            st.Push('A');
            st.Push("cat");
            st.Push(9);
            st.Push(22.54f);//last item in stack
            st.Pop();//removes last added item from the stack
            Console.WriteLine(st.Peek());
            foreach(var item in st )
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
