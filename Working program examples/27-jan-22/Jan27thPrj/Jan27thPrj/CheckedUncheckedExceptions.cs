using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27thPrj
{

    class CheckedUncheckedExceptions
    {
        //max value of integer
        static int maxInt = 214333765;

        //checked statement/expression
        static int CheckOverFlow()
        {
            int x = 0;
          
            try
            {
                //the below line raises an exception
                x = checked(maxInt + 10);
            }
            catch(System.OverflowException e)
            {
                Console.WriteLine("Checked:" + e.ToString());
            }
            return x;
        }

        //unchecked expression

        static int UnCheckOverFlow()
        {
            int x = 0;
            try
            {
                x=maxInt + 10;  
            }
            catch(System.OverflowException e)
            {
                Console.WriteLine("Unchecked:" + e.ToString());
            }

            //overflow is supressed
            //the sum of 214333765 + 10 is returned as -214333755
            return x;
        }
        static void Main()
        {
            Console.WriteLine("\nChecked output:{0}",CheckOverFlow());
            Console.WriteLine("\nUnChecked output:{0}", UnCheckOverFlow());
            Console.Read();
        }
    }
}
