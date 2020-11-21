using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Mid_Fall_20_21
{
    class Program
    {
        static void Main(string[] args)
        {
            University u1 = new University("AIUB");

            Department d1 = new Department("CSE", "101");
            Department d2 = new Department("EEE", "102");

            u1.AddDept(d1, d2);
            u1.ShowInfo();

            Course c1 = new Course("Java", "OOP", 3);
            Course c2 = new Course("C#", "OOP2", 3);
            Course c3 = new Course("Math", "Math01", 3);

            d1.AddCourse(c1, c2, c3);
            d1.ViewCourse();

            Faculty f1 = new Faculty("Rushee", "110");
            Faculty f2 = new Faculty("Tanvir Ahmed", "111");

            Section s1 = new Section("A",f1);
            Section s2 = new Section("B",f1);
            Section s3 = new Section("C",f1);
            Section s4 = new Section("A",f2);
            Section s5 = new Section("B",f2);
            Section s6 = new Section("C",f2);

            c1.AddSection(s1, s2, s3);
            c1.ViewSection();

            c2.AddSection(s4, s5, s6);
            c2.ViewSection();

            f1.AddSection(s1, s2, s3);
            f2.AddSection(s4, s5, s6);

            f1.ViewSection();
            f2.ViewSection();
        }
    }
}
