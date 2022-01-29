/* 1. Create a console application to book train tickets. 
Create a Passanger class with (Name, Age) and write a function called TicketBooking(no_of_tickets) that takes no.of tickets to be booked. 
If the no of tickets is > 5 per booking, raise an user defined exception, and print "cannot book more than 2 tickets". 
Else Print  "Ticket Booked Successfully". Add a Test class to call TicketBooking method by accepting all required details.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInterface
{
    
    class Passenger
    {
        public string Name;
        public int Age;

        public void Show()
        {
            Console.Write("Enter Name : ");
            Name =  Console.ReadLine();
            Console.Write("Enter Age : ");
            Age =  int.Parse(Console.ReadLine());
        }
        public void TicketBooking()
        {
            Console.Write("Enter the number of tickets to be booked :");
            int No_Of_Tickets=int.Parse(Console.ReadLine());
            if(No_Of_Tickets>5)
            {
                throw new TicketException("Cannot book more than 2 tickets");
            }
            else
                Console.WriteLine("Ticket booked successfully");
        }
        
    }
    class BookTicket
    {
        static void Main()
        {
            Passenger p=new Passenger();
            p.Show();
            try
            {
                p.TicketBooking();
            }
            catch (TicketException te)
            {
                Console.WriteLine(te.Message);
            }
            Console.Read();
        }
    }
}
