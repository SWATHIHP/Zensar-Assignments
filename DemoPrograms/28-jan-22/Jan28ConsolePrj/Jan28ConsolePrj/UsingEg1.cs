using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace Jan28ConsolePrj
{
    class UsingEg1
    {
        
        static void Main()
        {
            string multiplelines = @"This is line one
        This is line two
        here comes line 3
        Arrival of 4th line
        Final line 5";
            using (var reader=new StringReader(multiplelines))
            {
                string item;
                do
                {
                    item = reader.ReadLine();
                    Console.WriteLine(item);
                }while (item != null);
            }
            /* using (var streamReader=new StreamReader("D:\\file1.txt"))
             {
                 Console.WriteLine(streamReader.ReadToEnd());
             }*/

           /* var streamReader = new StreamReader("D:\\file1.txt");
            try
            {
                Console.WriteLine(streamReader.ReadToEnd());
            }
            finally
            {
                if(streamReader != null)
                    streamReader.Dispose();
            }*/
           using(var mydisposable=new MyDisposableClass())
            {
                mydisposable.DoSomeWork();
            }
            Console.ReadKey();
        }
    }
    public class MyDisposableClass : IDisposable
    {
        //zeroparameter consturctor
        public MyDisposableClass()
        {
            Console.WriteLine("Allocating Resources..");
        }
        //Normal Method
        public void DoSomeWork()
        {
            Console.WriteLine("I an Using Allotted Resources...");
        }
        //implementation of interface method
        public void Dispose()
        {
            Console.WriteLine("Releasing Resources");
        }
    }
}
