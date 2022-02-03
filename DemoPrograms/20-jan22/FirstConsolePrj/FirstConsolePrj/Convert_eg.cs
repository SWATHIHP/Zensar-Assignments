using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsolePrj
{
    class Convert_eg
    {
        //implicit and explicit conversions
        static void Main()
        {
            int i = 100;
            float f = i;//implicit conversion
            Console.WriteLine(f);
            f = 125.65f;
            i = Convert.ToInt32(f);//explicit conversion
           // i = int.Parse("26.8");
            Console.WriteLine(i);
            string str = "7659";
            //TryParse() takes a string as input and return boolean true n outputs the converted no. if success,
            //else returns only false. Does not throw any exception like parse or convert
            int res = 0;
            bool success=int.TryParse(str, out res);
            if(success)
            {
                Console.WriteLine(res);
            }
            else
                Console.WriteLine("Invalid input...could not convert");
            Console.Read();
        }
    }
}
