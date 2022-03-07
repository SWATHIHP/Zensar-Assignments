using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudntMgmtSystm
{
    abstract class UserInterface
    {
        public abstract void ShowFirstScreen();
        public abstract void ShowStudentScreen();
        public abstract void ShowAdminScreen();
        public abstract void ShowAllStudentsScreen();
        public abstract void ShowStudentRegistrationScreen();
        public abstract void IntroduceNewCourseScreen();
        public abstract void ShowAllCoursesScreen();
    }
}
