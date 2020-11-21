using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Mid_Fall_20_21
{
    class Faculty : Course
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private double teachingHour;

        public double TeachingHour
        {
            get { return teachingHour; }
            set { teachingHour = value; }
        }

        private Section[] facSections;

        public Section[] FacSections
        {
            get { return facSections; }
            set { facSections = value; }
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }


        //Cons
        public Faculty()
        {
            facSections = new Section[10];
        }
        public Faculty(string name, string id)
        {
            this.name = name;
            this.id = id;
            facSections = new Section[10];
        }

        //Method
        new public void ShowInfo()
        {
            Console.WriteLine("Faculty Name : " + name);
            Console.WriteLine("Faculty ID : " + id);
            
        }

        new public void AddSection(params Section[] sections)
        {
            foreach(var sec in sections)
            {
                if (teachingHour < 21  && teachingHour+WeeklyTeachingHour <= 21)
                {
                    teachingHour += WeeklyTeachingHour;
                    facSections[count++] = sec;
                }
                else
                    Console.WriteLine("Faculty cannot be added.");
            }

        }

        override public void ViewSection()
        {
            Console.WriteLine("\nFaculty's Sections : ");
            for (int i=0; i<count; i++)
            {
                facSections[i].ShowInfo();
            }
            Console.WriteLine();
        }

    }
}
