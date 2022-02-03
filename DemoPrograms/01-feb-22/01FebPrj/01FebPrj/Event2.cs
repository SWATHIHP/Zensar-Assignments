using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01FebPrj
{
    public delegate string MyDel(string s);
    class Event2
    {
        event MyDel MyEvent;

        public Event2()
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Welcome : " + username;
        }
        public string Message(string s)
        {
            return s;
        }
        static void Main()
        {
            Event2 eventobj=new Event2();
            string result = eventobj.MyEvent("To Events classes on C#");
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
