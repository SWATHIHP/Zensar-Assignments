using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Properties
{
    class Employee
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public Employee()
        {
            Counter++;
        }
        public static int Counter
        {
            get { return Counter; }
        }
    }

}
