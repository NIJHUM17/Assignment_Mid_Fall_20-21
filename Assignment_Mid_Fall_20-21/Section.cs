using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Mid_Fall_20_21
{
    class Section : Course
    {
        private string sec;

        public string Sec
        {
            get { return sec; }
            set { sec = value; }
        }

        private Faculty faculty;

        public Faculty Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }


        //Constractor

        public Section() { }
        public Section(string sec, Faculty faculty) 
        {
            this.sec = sec;
            this.faculty = faculty;
        }


        //Method

        public void AddFaculty(Faculty faculty)
        {
            if (Faculty.TeachingHour < 21 && Faculty.TeachingHour+WeeklyTeachingHour <= 21)
            {
                Faculty.TeachingHour += WeeklyTeachingHour;
            }
            else
                Console.WriteLine("Faculty cannot be added.");
        }
        
        override public void ShowInfo()
        {
            Console.WriteLine("Section : " + sec);
            Faculty.ShowInfo();
            Console.WriteLine();
        }

    }
}
