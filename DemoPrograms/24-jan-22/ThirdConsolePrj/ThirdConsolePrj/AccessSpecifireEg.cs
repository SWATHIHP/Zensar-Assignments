using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsolePrj
{
    class Products
    {
        int ProductId;//no access outside the class
        protected float ProductPrice;//accesible only within the class ans all derived class
        public string ProductName;//accesible anywhere
    }
    class AccessSpecifireEg:Products
    {
        static void Main()
        {
            Products prod = new Products();
            prod.ProductName = "Laptop";
            AccessSpecifireEg accessp=new AccessSpecifireEg();
            accessp.ProductName = "desktop";
            accessp.ProductPrice = 24000.50f;
        }
    }
    class Test
    {

    }
}
