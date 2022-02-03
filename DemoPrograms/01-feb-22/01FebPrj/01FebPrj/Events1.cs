using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01FebPrj
{
    public class EventTest
    {
        int value;
        public delegate void NumberManipulator();
        //Event declaration and association with the delegate is happening here
        public event NumberManipulator changenum;

        public virtual void onNumChanged()
        {
            Console.WriteLine("Event raised and value changed");
        }
        public EventTest(int n)
        {
            this.changenum += new NumberManipulator(this.onNumChanged);
            setvalue(n);
        }
        public void setvalue(int n)
        {
            if(value != n)
            {
                value = n;
                onNumChanged();
            }
        }
    }
    class Events1
    {
        static void Main()
        {
            EventTest t=new EventTest(11);
            t.setvalue(11);
            t.setvalue(22);
            t.setvalue(23);


            Console.Read();
        }
    }
}
