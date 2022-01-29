/*3.Create an Interface IStudent with StudentId and Name as Properties, ShowDetails() as its method. Create 2 classes Dayscholar 
 * and Resident that implements the interface Properties and Methods. Test The functionalities.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInterface
{
    interface IStudent
    {
      // void ShowDetails(int ID, string n);
    }

    class DayScholar : IStudent
    {
        public void ShowDetails(int ID, string n)
        {
            Console.WriteLine($"The Student with ID : {ID} and Name : {n} is a DayScholar Student.");
        }

    }
   
        
    class Resident : IStudent
    {
        public void ShowDetails(int ID, string n)
        {
            Console.WriteLine($"The Student with ID : {ID} and Name : {n} is a Resident Student.");

        }

    }
    class Program
    {
        static void Main()
        {

            DayScholar dc = new DayScholar();
            dc.ShowDetails(111, "Swathi");
            Resident r = new Resident();
            r.ShowDetails(333, "Sahana");
            Console.Read();
        }
    }
}
