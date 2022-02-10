using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Prj
{
    class DI_Poject
    {
       static void Main()
        {
            //creating microsoft unity container
            UnityContainer UC=new UnityContainer();

            //register all types
            UC.RegisterType<BL>();
            UC.RegisterType<DataAccess>();
            UC.RegisterType<IProduct,DataAccess>();
            UC.RegisterType<IOrder,ML>();
            BL business=UC.Resolve<BL>();
            business.Insert();//BL instance method
            Console.Read();
        }
    }
}
