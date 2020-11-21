using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Mid_Fall_20_21
{
    class Course
    {
        private string courseName;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        private string courseId;

        public string CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }

        private double weeklyTeachingHour;

        public double WeeklyTeachingHour
        {
            get { return weeklyTeachingHour; }
            set { weeklyTeachingHour = value; }
        }

        private int secCount;

        public int SecCount
        {
            get { return secCount; }
            set { secCount = value; }
        }


        private Section[] sections;

        public Section[] Sections
        {
            get { return sections; }
            set { sections = value; }
        }

        //Constractor
        public Course()
        {
            sections = new Section[5];
        }
        public Course(string courseName, string courseId, double weeklyTeachingHour)
        {
            this.courseName = courseName;
            this.courseId = courseId;
            this.weeklyTeachingHour = weeklyTeachingHour;
            sections = new Section[5];
        }

        //Method
        virtual public void ShowInfo()
        {
            Console.WriteLine("Course Name : " + courseName);
            Console.WriteLine("Course ID : " + courseId);
            Console.WriteLine("Teaching Hour : " + weeklyTeachingHour);
        }

        public void AddSection(params Section[] sec)
        {
            foreach(var s in sec)
            {
                if(secCount < 5)
                    sections[secCount++] = s;
                else
                    Console.WriteLine("Section is full.");
            }
        }

        virtual public void ViewSection()
        {
            Console.WriteLine("\nSection Info : ");
            ShowInfo();
            for (int i = 0; i < secCount; i++)
            {
                sections[i].ShowInfo();
            }
            Console.WriteLine();
        }

    }
}
