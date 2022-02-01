using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;

namespace CalculatorExtension2
{
    public class Class1
    {
        public static string Message(this Calculatorclass cobj,string str)
        {
            return "Hello" + " " + str;

        }
        public static int Divide(this Caculatorclass cobj,int x, int y)
        {

        }
    }
}
