using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;
using static System.Console;
using System.Threading;

namespace Feb2Prj
{
    class Features
    {
        public static int year = 2016;
        static void Main()
        {
            try
            {
                int[] a = new int[5];
                a[1] = 22;
                int num = 0;
                int answers = 5 / num;
            }
            catch (Exception ex)when (ex.GetType().ToString()=="Sytem.IndexOutOfRangeException")
            {
                SomeotherFunction();

            }
            catch(DivideByZeroException) when(DateTime.Now.DayOfWeek!=DayOfWeek.Monday)
            {
                Console.WriteLine("Sorry..today is not monday");
            }
            catch (DivideByZeroException) when (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine("Welcome..you can register today");
            }

            //literal improvements (_)
            var lit1 = 954_32_345_67;//digit seperators
            var lit2 = 0xu0_5f;//hexadecimal literal
            var lit3 = 1001_111_001;
            Console.WriteLine($"lit1 : {lit1},lit2 : {lit2},lit3 : {lit3}");
            
            Console.WriteLine(LeapYear());
            Console.WriteLine("Enter the side of square");
            int s=ToInt32(ReadLine());
            int square = AreaOfSquare(s);

            Thread.Sleep(3000);
            Write($"Area of square is {square}");
            Console.Read();
        }
        static void SomeotherFunction()
        {
            Console.WriteLine("IT is a new task...");
        }

        //normal way of writing a function
        /* public static string LeapYear()
         {
             return "\n Is" + year + " a leap year " + DateTime.IsLeapYear(year);

         }*/

        //with expression bodied member
        public static string LeapYear() => $"\n Is {year} a leap year - " + DateTime.IsLeapYear(year);
        public static int AreaOfSquare(int side) => side * side;
    }
}
