using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudntMgmtSystm
{
    class AppEngine
    {
            public static SqlCommand cmd;
            public static SqlConnection con;
            public static SqlDataReader dr;
            public static string connections = "data source=ADMIW58ZLPC0665\\SQLEXPRESS;initial catalog=Student_Course_Enroll;integrated security=true";

            public static void Introduce(List<Course> course)
            {
                try
                {
                    con = getConnection();
                    int id;
                    float duration, fee;
                    string name;
                    Console.WriteLine("Enter Course ID : ");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Course Name : ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter Course Duration : ");
                    duration = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Course Fees : ");
                    fee = float.Parse(Console.ReadLine());
                    cmd = new SqlCommand("Insert into CourseEnroll values(@c_id,@c_name,@c_duration,@c_fee)");
                    cmd.Parameters.AddWithValue("@c_id", id);
                    cmd.Parameters.AddWithValue("@c_name", name);
                    cmd.Parameters.AddWithValue("@c_duration", duration);
                    cmd.Parameters.AddWithValue("@c_fee", fee);
                    cmd.Connection = con;
                    int no_ofrows = cmd.ExecuteNonQuery();
                    if (no_ofrows > 0)
                    {
                        course.Add(new Course(id, name, duration, fee));
                    }
                    else
                    {
                        Console.WriteLine("Oops..Problem Encountered!!");
                    }
                    con.Close();
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
            }

            public static void register(List<Student> students)
            {
                try
                {
                    con = getConnection();
                    int id;
                    string name;
                    DateTime dob;
                    Console.WriteLine("Enter Student ID : ");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Student Name : ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter Student Date of Birth : ");
                    dob = Convert.ToDateTime(Console.ReadLine());
                    cmd = new SqlCommand("Insert into StudentEnroll values(@s_id,@s_name,@s_dob)");
                    cmd.Parameters.AddWithValue("@s_id", id);
                    cmd.Parameters.AddWithValue("@s_name", name);
                    cmd.Parameters.AddWithValue("@s_dob", dob);
                    cmd.Connection = con;
                    int no_ofrows = cmd.ExecuteNonQuery();
                    if (no_ofrows > 0)
                    {
                        students.Add(new Student(id, name, dob));
                    }
                    else
                    {
                        Console.WriteLine("Oops..Problem Encountered!!");
                    }
                    con.Close();
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
            }

            public static List<Student> ListOfStudents(List<Student> students)
            {
                con = getConnection();
                cmd = new SqlCommand("select * from StudentEnroll", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("+++++++++++++++Student Details+++++++++++");
                    Console.WriteLine();
                    Console.WriteLine("Student ID : {0}", dr[0]);
                    Console.WriteLine("Student Name : {0}", dr[1]);
                    Console.WriteLine("Student Date of Birth : {0}", dr[2]);
                    students.Add(new Student((int)dr[0], (string)dr[1], (DateTime)dr[2]));
                }
                dr.Close();
                con.Close();
                return students;
            }
            public static List<Course> ListOfCourses(List<Course> course)
            {
                con = getConnection();
                cmd = new SqlCommand("select * from CourseEnroll", con);
                dr = cmd.ExecuteReader();
                Console.WriteLine("+++++++++++++++++Course Details+++++++++++");
                Console.WriteLine();
                while (dr.Read())
                {
                    Console.WriteLine("Course Id : " + " " + dr[0]);
                    Console.WriteLine("Course Name :" + " " + dr[1]);
                    Console.WriteLine("Course Duration :" + " " + dr[2]);
                    Console.WriteLine("Course Fees :" + " " + dr[3]);
                    //Console.WriteLine("--------------------------");
                }
                dr.Close();
                con.Close();
                return course;
            }

            /* public static List<Course> ListOfCourses(List<Course> courses)
             {
                 con = getConnection();
                 cmd = new SqlCommand("select * from CourseEnroll", con);
                 dr = cmd.ExecuteReader();
                 while (dr.Read())
                 {
                     Console.WriteLine("+++++++++++++++++Course Details+++++++++++");
                     Console.WriteLine();
                     Console.WriteLine("Course ID : {0}", dr[0]);
                     Console.WriteLine("Course Name : {0}", dr[1]);
                     Console.WriteLine("Course Duration : {0}", dr[2]);
                     Console.WriteLine("Course Fee : {0}", dr[3]);
                     courses.Add(new Course((int)dr[0], (string)dr[1], (float)dr[2], (float)dr[3]));
                 }
                 dr.Close();
                 con.Close();
                 return courses;
             }*/

            public static void enroll()
            {
                Enroll enroll = new Enroll();
                try
                {
                    int sid, cid;
                    con = getConnection();
                    Console.WriteLine("Enter your Student ID : ");
                    sid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter ID of the Course to be selected : ");
                    cid = int.Parse(Console.ReadLine());
                    cmd = new SqlCommand("insert into EnrollmentInfo values(@stid,@crid,@dt)", con);
                    cmd.Parameters.AddWithValue("@stid", sid);
                    cmd.Parameters.AddWithValue("@crid", cid);
                    cmd.Parameters.AddWithValue("@dt", DateTime.UtcNow);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Data Insertion Successfull!!");
                    }
                    else
                    {
                        Console.WriteLine("Oops..Problem Encountered!!");
                    }
                    con.Close();
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
            }

            public static List<Enroll> ListOfEnrollment(List<Enroll> enrolls)
            {
                con = getConnection();
                cmd = new SqlCommand("select * from EnrollmentInfo", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("+++++++++++++Student Enrollment Details+++++++++");
                    Console.WriteLine();
                    Console.WriteLine("Student ID : {0}", dr[0]);
                    Console.WriteLine("Course ID : {0}", dr[1]);
                    Console.WriteLine("Date of Enrollment : {0}", dr[2]);
                    enrolls.Add(new Enroll());
                }
                dr.Close();
                con.Close();
                return enrolls;
            }

            public static SqlConnection getConnection()
            {
                con = new SqlConnection(connections);
                con.Open();
                return con;
            }
            public static void GetPerStudDetails()
            {
                Console.WriteLine("Enter your Student ID : ");
                int id = int.Parse(Console.ReadLine());
                con = getConnection();
                cmd = new SqlCommand("select * from StudentEnroll where s_id = @sid");
                cmd.Parameters.AddWithValue("@sid", id);
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("++++++++++++Student Details+++++++++++");
                    Console.WriteLine("======================================");
                    Console.WriteLine("Student ID : {0}", dr[0]);
                    Console.WriteLine("Student Name : {0}", dr[1]);
                    Console.WriteLine("Student Date of Birth : {0}", dr[2]);
                }
                dr.Close();
                con.Close();
            }

            /*public static void GetPerStudDetails()
            {
                Console.WriteLine("Enter your Student ID : ");
                int id = int.Parse(Console.ReadLine());
                con = getConnection();
                cmd = new SqlCommand("select * from StudentEnroll where Sid = @s_id");
                cmd.Parameters.AddWithValue("@s_id", id);
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("++++++++++++Student Details+++++++++++");
                    Console.WriteLine("======================================");
                    Console.WriteLine("Student ID : {0}", dr[0]);
                    Console.WriteLine("Student Name : {0}", dr[1]);
                    Console.WriteLine("Student Date of Birth : {0}", dr[2]);
                }
                dr.Close();
                con.Close();
            }*/

            public static void GetPerCourseDetails()
            {
                Console.WriteLine("Enter your Course ID : ");
                int id = int.Parse(Console.ReadLine());
                con = getConnection();
                cmd = new SqlCommand("select * from CourseEnroll where c_id = @cid");
                cmd.Parameters.AddWithValue("@cid", id);
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("+++++++++++++++++++Course Details++++++++++++");
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Course ID : {0}", dr[0]);
                    Console.WriteLine("Course Name : {0}", dr[1]);
                    Console.WriteLine("Course Duration : {0}", dr[2]);
                    Console.WriteLine("Course Fee : {0}", dr[3]);
                }
                dr.Close();
                con.Close();
            }

            public static void DeleteCourse()
            {
                con = getConnection();
                Console.Write("Enter the Course ID to be Deleted : ");
                int cid = int.Parse(Console.ReadLine());
                SqlCommand cmd1 = new SqlCommand("Select * from CourseEnroll where c_id = @cid", con);
                cmd1.Parameters.AddWithValue("@cid", cid);
                try
                {
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        for (int i = 0; i < dr1.FieldCount; i++)
                        {
                            Console.WriteLine(dr1[i]);
                        }
                    }
                    dr1.Close();
                    Console.WriteLine("Are you sure to delete the above Data yes or no (Y/N) : ");
                    string status = Console.ReadLine();
                    if ((status == "yes") || (status == "Yes") || (status == "y") || (status == "Y"))
                    {
                        cmd = new SqlCommand("delete from CourseEnroll where c_id = @cid");
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.Connection = con;
                        int res = cmd.ExecuteNonQuery();
                        if (res > 0)
                        {
                            Console.WriteLine("Record Deletion Successfull!!");
                        }
                        else
                        {
                            Console.WriteLine("Something Went wrong in the Deletion Process");
                        }
                    }
                    con.Close();
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
            }

            public static void UpdateCourseInfo()
            {
                con = getConnection();
                Console.WriteLine("Enter the Course ID to be Updated : ");
                int cid = int.Parse(Console.ReadLine());
                SqlCommand cmd1 = new SqlCommand("Select * from CourseEnroll where c_id = @cid", con);
                cmd1.Parameters.AddWithValue("@cid", cid);
                try
                {
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        for (int i = 0; i < dr1.FieldCount; i++)
                        {
                            Console.WriteLine(dr1[i]);
                        }
                    }
                    dr1.Close();
                    Console.WriteLine("Are you sure to update the Student Date of Birth yes or no (Y/N) : ");
                    string status = Console.ReadLine();
                    if ((status == "yes") || (status == "Yes") || (status == "y") || (status == "Y"))
                    {
                        Console.WriteLine("Enter the Course Duration and Course Fee ");
                        float cd = float.Parse(Console.ReadLine());
                        float cf = float.Parse(Console.ReadLine());
                        cmd = new SqlCommand("update CourseEnroll set c_duration = @cdur,c_fee = @cfee where c_id = @cid");
                        cmd.Parameters.AddWithValue("@cdur", cd);
                        cmd.Parameters.AddWithValue("@cfee", cf);
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.Connection = con;
                        int res = cmd.ExecuteNonQuery();
                        if (res > 0)
                        {
                            Console.WriteLine("Record Updation Successfull!!");
                        }
                        else
                        {
                            Console.WriteLine("Something Went wrong in the Updation Process");
                        }
                    }
                    con.Close();
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
            }

            public static void UpdateStudInfo()
            {
                con = getConnection();
                Console.WriteLine("Enter the Student ID to be Updated : ");
                int sid = int.Parse(Console.ReadLine());
                SqlCommand cmd1 = new SqlCommand("Select * from StudentEnroll where s_id = @stid", con);
                cmd1.Parameters.AddWithValue("@stid", sid);
                try
                {
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        for (int i = 0; i < dr1.FieldCount; i++)
                        {
                            Console.WriteLine(dr1[i]);
                        }
                    }
                    dr1.Close();
                    Console.WriteLine("Are you sure to update the Student Date of Birth yes or no (Y/N) : ");
                    string status = Console.ReadLine();
                    if ((status == "yes") || (status == "Yes") || (status == "y") || (status == "Y"))
                    {
                        Console.WriteLine("Enter new Date of Birth : ");
                        DateTime dt = Convert.ToDateTime(Console.ReadLine());
                        cmd = new SqlCommand("update StudentEnroll set s_dob = @date where s_id = @stid");
                        cmd.Parameters.AddWithValue("@date", dt);
                        cmd.Parameters.AddWithValue("@stid", sid);
                        cmd.Connection = con;
                        int res = cmd.ExecuteNonQuery();
                        if (res > 0)
                        {
                            Console.WriteLine("Record Updation Successfull!!");
                        }
                        else
                        {
                            Console.WriteLine("Something Went wrong in the Updation Process");
                        }
                    }
                    con.Close();
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
            }

            public static void DeleteStudent()
            {
                con = getConnection();
                Console.WriteLine("Enter the Student Id to be Deleted : ");
                int sid = int.Parse(Console.ReadLine());
                SqlCommand cmd1 = new SqlCommand("select * from StudentEnroll where s_id = @sid", con);
                cmd1.Parameters.AddWithValue("@sid", sid);
                try
                {
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        for (int i = 0; i < dr1.FieldCount; i++)
                        {
                            Console.WriteLine(dr1[i]);
                        }
                    }
                    dr1.Close();
                    Console.Write("Are you sure to delete the above data yes or no (Y/N) : ");
                    string status = Console.ReadLine();
                    if ((status == "yes") || (status == "Yes") || (status == "y") || (status == "Y"))
                    {
                        cmd = new SqlCommand("delete from StudentEnroll where s_id = @sid");
                        cmd.Parameters.AddWithValue("@sid", sid);
                        cmd.Connection = con;
                        int res = cmd.ExecuteNonQuery();
                        if (res > 0)
                        {
                            Console.WriteLine("Record Deletion Successfull!!");
                        }
                        else
                        {
                            Console.WriteLine("Something Went wrong in the Deletion Process");
                        }
                    }
                    con.Close();
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
            }
        }
}
