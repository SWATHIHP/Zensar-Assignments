using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_ConsoleDay2
{
    class Program
    {

        static void Main(string[] args)
        {
            //implicitly typed variable
            var v = 23.8750f;
            //dynamic type
            dynamic d;
            d = 'a';
            d = 10;

            Console.WriteLine(d);
            //eg. for nullable value type
            int? num1;//making int a nullable value type by using '?'
            num1 = 10;
            string s = null;
            int? TicketsOnSale = 100;
            int AvailableTickets;
            if (TicketsOnSale == null)
            {
                AvailableTickets = 0;
            }
            else
            {
                AvailableTickets=(int) TicketsOnSale;//or
                AvailableTickets=TicketsOnSale.Value;
            }
            Console.WriteLine("Available Tickets = {0}",AvailableTickets);
            //null coalescing operator
            int? T_onSale = null;//can give any int value like 100
            int A_Tickets = T_onSale ?? 0;
            Console.WriteLine("Available Tickets = {0}", A_Tickets);

            Console.Read();
        }
    }
}
