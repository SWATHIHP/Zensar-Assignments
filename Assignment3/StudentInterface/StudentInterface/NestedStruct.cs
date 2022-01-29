/*5. Write a program in C# Sharp to create a nested structure to store two data for an employee in an array. 

Test Data:

Create a nested structure and store data in an array :                              
-------------------------------------------------------                          
Name of the employee : H.Rana                                                    
Input day of the birth : 05                                                      
Input month of the birth : 02                                                    
Input year for the birth : 58                                                    
                                                                                 
Name of the employee : S.Mathur                                                  
Input day of the birth : 04                                                      
Input month of the birth : 08                                                    
Input year for the birth : 59 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInterface
{
    class NestedStruct
    {
        struct Employee
        {
            public string EmpName;
            public DOB Date;
        }
        struct DOB
        {
            public int Day;
            public int Month;
            public int Year;
        }
        static void Main()
        {
            int dd = 0, mm = 0, yy = 0;
            int total = 2;
            Console.WriteLine("Create a nested structure and store data in an array :");
            Console.WriteLine("------------------------------------------------------");
            Employee[] emp=new Employee[total];
            for (int i = 0; i < total; i++)
            {
                Console.Write("Name of the employee : ");
                string nm = Console.ReadLine();
                emp[i].EmpName = nm;

                Console.Write("Input day of the birth : ");
                dd = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Day = dd;

                Console.Write("Input month of the birth : ");
                mm = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Month = mm;

                Console.Write("Input year for the birth : ");
                yy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                emp[i].Date.Year = yy;
            }
            Console.Read();
        }
    }
}
