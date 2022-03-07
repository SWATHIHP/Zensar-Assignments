using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudntMgmtSystm
{
    class Student
    {
        private int Stud_ID;
        public int Student_Id
        {
            get { return Stud_ID; }
            set { Stud_ID = value; }
        }

        private string Stud_Name;
        public string Student_Name
        {
            get
            { return Stud_Name; }
            set
            { Stud_Name = value; }
        }

        private DateTime Stud_DOB;

        public DateTime DOB
        {
            get
            { return Stud_DOB; }
            set
            { Stud_DOB = value; }
        }

        public Student()
        {

        }

        public Student(int a, string b, DateTime dob)
        {
            Student_Id = a;
            Student_Name = b;
            DOB = dob;
        }
    }
    class Course
    {
        private int Course_ID;
        public int Course_Id
        {
            get { return Course_ID; }
            set { Course_ID = value; }
        }
        private string Course_Name;
        public string Course_name
        {
            get { return Course_Name; }
            set { Course_Name = value; }
        }
        public float Course_Duration { get; set; }
        public float Course_Fees { get; set; }

        public Course()
        {

        }

        public Course(int id, string name, float duration, float fees)
        {
            Course_Id = id;
            Course_name = name;
            Course_Duration = duration;
            Course_Fees = fees;
        }
    }
    class Enroll
    {
        public Student student = new Student();
        public Course course = new Course();
        private DateTime enrollmentDate;

        public List<Course> CourseList = new List<Course>();
        public List<Student> StudentList = new List<Student>();
        public List<Enroll> EnrollList = new List<Enroll>();

        public Enroll()
        {

        }

        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }
    }
    class Program : UserInterface
    {
        public static Enroll enroll = new Enroll();

        private string ans;

        public override void IntroduceNewCourseScreen()
        {
            Console.WriteLine("+++++++++++Welcome to Adding New Course Screen+++++++++++ ");
            AppEngine.Introduce(enroll.CourseList);
        }

        public override void ShowAdminScreen()
        {
            do
            {
                Console.WriteLine("+++++++++++++++++++++Welcome to Admin Screen++++++++++++++++++ ");
                Console.WriteLine("Do you want to choose : \n" +
                    "1. Student Details \n" +
                    "2. Course Details \n" +
                    "3. Insert New Student \n" +
                    "4. Update Existing Student Details \n" +
                    "5. Delete Existing Student Details \n" +
                    "6. Insert New Course \n" +
                    "7. Update Existing Course Details \n" +
                    "8. Delete Existing Course Details \n" +
                    "9. Enrollment List");
                Console.Write("Enter your choice between 1 to 9 : ");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        ShowAllStudentsScreen();
                        break;
                    case 2:
                        ShowAllCoursesScreen();
                        break;
                    case 3:
                        ShowStudentRegistrationScreen();
                        break;
                    case 4:
                        AppEngine.UpdateStudInfo();
                        break;
                    case 5:
                        AppEngine.DeleteStudent();
                        break;
                    case 6:
                        IntroduceNewCourseScreen();
                        break;
                    case 7:
                        AppEngine.UpdateCourseInfo();
                        break;
                    case 8:
                        AppEngine.DeleteCourse();
                        break;
                    case 9:
                        AppEngine.ListOfEnrollment(enroll.EnrollList);
                        break;
                }
                Console.Write("Do you want to continue in Admin Screen Yes or No (Y/N) : ");
                ans = Console.ReadLine();
            } while ((ans == "yes") || (ans == "Yes") || (ans == "y") || (ans == "Y"));
        }
        public override void ShowAllStudentsScreen()
        {
            Console.WriteLine("+++++++++++++++++++++Welcome to the List of Student Details++++++++++++++++++++ ");
            AppEngine.ListOfStudents(enroll.StudentList);
        }

        public override void ShowAllCoursesScreen()
        {
            Console.WriteLine("+++++++++++++++++++++++Welcome to the List of Course Details+++++++++++++++++++++++++++ ");
            AppEngine.ListOfCourses(enroll.CourseList);
        }

        public override void ShowFirstScreen()
        {
            do
            {
                Console.WriteLine("=============================================Welcome to STUDENT MANAGEMENT SYATEM====================================");
                Console.WriteLine("Tell us who you are : \n1. Admin\n2. Student");
                Console.Write("Enter your choice 1 or 2 : ");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        ShowAdminScreen();
                        break;
                    case 2:
                        ShowStudentScreen();
                        break;
                }
                Console.Write("Do you want to continue in Main Screen Yes or No (Y/N) : ");
                ans = Console.ReadLine();
            } while ((ans == "yes") || (ans == "Yes") || (ans == "y") || (ans == "Y"));
        }

        public override void ShowStudentRegistrationScreen()
        {
            Console.WriteLine("+++++++++Welcome to Student Registration Screen+++++++ ");
            AppEngine.register(enroll.StudentList);
        }

        public override void ShowStudentScreen()
        {
            do
            {
                Console.WriteLine("--------------------Welcome to Student Screen---------------- ");
                Console.WriteLine("Do you want to choose : \n1. Student Details \n2. Available Courses \n3. Enroll in New Course");
                Console.Write("Enter your choice  1 or 2 or 3 : ");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("\t\t\t +++++++++++++++Student Screen+++++++++++ ");
                        AppEngine.GetPerStudDetails();
                        break;
                    case 2:
                        ShowAllCoursesScreen();
                        break;
                    case 3:
                        Enrollment();
                        break;
                }
                Console.Write("Do you want to continue in Student Screen Yes or No (Y/N) :  ");
                ans = Console.ReadLine();
            } while ((ans == "yes") || (ans == "Yes") || (ans == "y") || (ans == "Y"));
        }

        public void Enrollment()
        {
            AppEngine.enroll();
        }
    }
}
