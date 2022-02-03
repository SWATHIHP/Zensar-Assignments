using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    class Product
    {
        public int Id;
        public string Name;
        Dictionary<string, Double> Product1 = new Dictionary<string, double>();

        public void GetData()
        {
            Console.WriteLine("Enter 10 Elements : ");
            for (int i = 0; i < 10; i++)
            {
                Product1.Add(Console.ReadLine(), double.Parse(Console.ReadLine()));
            }
        }
        public void Sortdata()
        {
            Console.WriteLine("++++++++++++++++Sorted by Price+++++++++++++++");
            Console.WriteLine("-----------------------------------------------");
            foreach (KeyValuePair<string, Double> Price in Product1.OrderBy(key => key.Value))
            {
                Console.WriteLine("Key: {0}, Value: {1}", Price.Key, Price.Value);
            }
        }
    }
    class Products
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.GetData();
            p.Sortdata();
        }
    }
}
