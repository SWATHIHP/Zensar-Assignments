/* Create a console application to book train tickets. 
Create a Passanger class with (Name, Age) and write a function called TicketBooking(no_of_tickets) that takes no.of tickets to be booked. 
If the no of tickets is > 5 per booking, raise an user defined exception, and print "cannot book more than 2 tickets". 
Else Print  "Ticket Booked Successfully". Add a Test class to call TicketBooking method by accepting all required details.
 */
using System;
using System.Runtime.Serialization;

namespace StudentInterface
{
    [Serializable]
    internal class TicketException : Exception
    {
        public TicketException()
        {
        }

        public TicketException(string message) : base(message)
        {
        }

        public TicketException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TicketException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}