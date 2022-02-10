using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb4Prj
{
    class Ref_locals_Ref_returns
    {
        static void Main()
        {
            int n1 = 5;
            ref int n2 = ref n1;//we are giving the reference of n1 to a local variable n2
            n2 = 10;
            Console.WriteLine($"Local variable : {nameof(n1)},{nameof(n2)} after the change : {n1}");
            n1 = 20;
            Console.WriteLine($"Local variable : {nameof(n1)},{nameof(n2)} after the change : {n1}");

            //getting the reference from ef returns
            char[] array = { 'n','a', 'm','j','o','o','n'};
            Console.WriteLine($"Before ref returns : {new string(array)}");
            ref char cref=ref Ref_returns.FindCharRef('w',array);
            cref = 'e';//replacing the value fropm 'a' to 'e' from the location which is pointed by cref
            Console.WriteLine($"After ref returns : {new string(array)}");


            Console.Read();
        }
    }
    class Ref_returns
    {
        public static ref char FindCharRef(char c,char[] carray)
        {
            for(int i = 0; i < carray.Length; i++)
            {
                if(carray[i] == c)
                {
                    return ref carray[i];//returns the storage location and not the value of the matched character

                }
            }
            throw new IndexOutOfRangeException(c + " " + "not found");
        }
    }
}
