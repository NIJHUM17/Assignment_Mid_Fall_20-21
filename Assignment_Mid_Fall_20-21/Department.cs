using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Mid_Fall_20_21
{
    class Department
    {
        private string deptName;

        public string DeptName
        {
            get { return deptName; }
            set { deptName = value; }
        }

        private string deptId;

        public string DeptId
        {
            get { return deptId; }
            set { deptId = value; }
        }

        private int courseCount;

        public int CourseCount
        {
            get { return courseCount; }
            set { courseCount = value; }
        }

        private Course[] courses;

        public Course[] Courses
        {
            get { return courses; }
            set { courses = value; }
        }

        //Constructors
        public Department()
        {
            courses = new Course[20];
        }
        public Department(string deptName, string deptId)
        {
            this.deptName = deptName;
            this.deptId = deptId;
            courses = new Course[20];
        }

        //Methods
        public void ShowInfo()
        {
            Console.WriteLine("Department : " + deptName);
            Console.WriteLine("Department ID : " + deptId);
        }

        public void AddCourse(params Course[] crs)
        {
            foreach(var c in crs)
            {
                if (courseCount < 20)
                    courses[courseCount++] = c;
                else
                    Console.WriteLine("No more course can be added.");
            }
        }

        public void ViewCourse()
        {
            Console.WriteLine("\nCourse Info : ");
            ShowInfo();
            for(int i = 0; i<courseCount; i++)
            {
                courses[i].ShowInfo();
            }
            Console.WriteLine();
        }
    }
}
