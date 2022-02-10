using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Prj
{
    class DataAccess : IProduct
    {
        public string InsertData()
        {
            string str = "Dependency injection ---Injected";
            Console.WriteLine(str);
            return str;
        }
    }

}
