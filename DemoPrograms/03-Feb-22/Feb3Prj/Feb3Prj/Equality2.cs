using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb3Prj
{
    class Equality2
    {
        static void Main()
        {
            //string name = "Namjoon";
            //string myname = name;
            //Console.WriteLine("== operator result is {0}",name==myname);
            //Console.WriteLine("Equals method result is {0}",name.Equals(myname));
            object oname = "Namjoon";
            char[] val = { 'N', 'a', 'm', 'j', 'o', 'o', 'n' };
            object oname2 = new string(val);
            Console.WriteLine("== operator result is {0}", oname == oname2);
            Console.WriteLine("Equals method result is {0}", oname.Equals(oname2));

            Console.Read();
        }
    }
}
