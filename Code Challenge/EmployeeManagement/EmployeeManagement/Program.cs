using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EmployeeManagement
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        static void Main(string[] args)
        {
            InsertData();
        }

        static void InsertData()
        {
            try
            {
                con = GetConnection();
                Console.WriteLine("Enter the employee details below... ");
                Console.WriteLine("------------------------------------");
                string EmpName, EmpType;
                float EmpSal;
                Console.Write("Enter Employee Name : ");
                EmpName = Console.ReadLine();
                Console.Write("Enter Employee Salary : ");
                EmpSal = float.Parse(Console.ReadLine());
                Console.Write("Enter Employee Type 'C' Or 'P' :");
                EmpType = Console.ReadLine();
                cmd = new SqlCommand("execute dbo.AddNewEmployee @ename, @esal, @etype");
                cmd.Parameters.AddWithValue("@ename", EmpName);
                cmd.Parameters.AddWithValue("@esal", EmpSal);
                cmd.Parameters.AddWithValue("@etype", EmpType);
                cmd.Connection = con;
                int numofrows = cmd.ExecuteNonQuery();
                if (numofrows > 0)
                {
                    Console.Write("Number of row(s) affected are : {0} ", numofrows);
                }
                else
                {
                    Console.WriteLine("Someting went wrong!!");
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            Console.Read();
        }

        static SqlConnection GetConnection()
        {
            con = new SqlConnection(@"data source=ADMIW58ZLPC0665\SQLEXPRESS;initial catalog=EmployeManagement;integrated security=true");
            con.Open();
            return con;
        }
    }
}
