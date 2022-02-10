using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb4Prj
{
    class expression
    {
        int[] array = new int[5];

        public static void Main()
        {
            expression r = new expression();
            try
            {
                r.Show(r.array);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("The name of the method is : " + nameof(r.Show) + " " + "The vaiable is : " + nameof(r.array));

            }
            Console.ReadLine();

        }
        public int Show(int[] x)
        {
            x[5] = 10;
            return x[5];
        }
    }
}
