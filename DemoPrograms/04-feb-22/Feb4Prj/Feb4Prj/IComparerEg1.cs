using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb4Prj
{
    
        public class Display
        {
            public int PPI { get; set; }
            public string Resolution { get; set; }
            public string size { get; set; }
        }
        public class SortDisplay : IComparer<Display>
        {
            public int Compare(Display x, Display y)
            {
                Display first = x;
                Display second = y;
                return first.PPI.CompareTo(second.PPI);
            }
        }

        class IComparerEg1
        {
        public int Show(int[] x)
        {
            x[5] = 10;
            return x[5];
        }
            public static void Main()
            {
                List<Display> displays = new List<Display>()
            {
                new Display()
                {
                    PPI =334,
                    Resolution ="1080 * 1920",
                    size ="5.6"
                },
                new Display()
                {
                    PPI =224,
                    Resolution ="1080 * 720",
                    size ="7.11"
                },
                new Display()
                {
                    PPI =334,
                    Resolution ="340 * 980",
                    size ="6.6"
                }
            };
            SortDisplay sd = new SortDisplay();
            displays.Sort(sd);
            foreach (var item in displays)
            {
                Console.WriteLine($"PPI : {item.PPI}, Resolution : {item.Resolution} and size is : {item.size}");
            }
        }
    }
    
}


