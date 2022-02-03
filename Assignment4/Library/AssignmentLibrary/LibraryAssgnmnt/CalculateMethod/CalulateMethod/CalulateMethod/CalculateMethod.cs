using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalulateMethod
{
    class CalculateMethod
    {
        public double CalculateConcession(int age, int Fare)
        {
            double fare;
            if (age <= 5)
            {
                Console.WriteLine("Little Champs - Free Ticket.");
            }
            else if (age > 60)
            {
                double ans = 0.3;
                fare = Fare * ans;
                Console.WriteLine("Senior Citizen Fare : {0}", fare);
            }
            else
            {
                Console.WriteLine("Print Tickets Booked with Fare : {0}", Fare);
            }
            return 0;
        }
    }
}
