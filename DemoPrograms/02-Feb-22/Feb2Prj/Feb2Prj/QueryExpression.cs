using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb2Prj
{
    class QueryExpression
    {
        static void Main()
        {
            int[] numbers = { 4, 6, 22, 54,67,33,76 };
            int[] val = { 4, 33, 34, 11, 57 ,98,5};
            //query expression(will always starts with "from" keyword)
            var res=from x in numbers
                    where x > 44
                    orderby x
                    select x.ToString();

            var res1=from m in val
                     where (m %2)!=0
                     select m;

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            foreach (var item in val)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
