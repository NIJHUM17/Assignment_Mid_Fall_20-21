using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Mid_Fall_20_21
{
    class University
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Department[] departments;

        public Department[] Departments
        {
            get { return departments; }
            set { departments = value; }
        }

        private int deptCount;

        public int DeptCount
        {
            get { return deptCount; }
            set { deptCount = value; }
        }

        //Cons
        public University()
        {
            departments = new Department[10];
        }
        public University(string name)
        {
            this.name = name;
            departments = new Department[10];
        }

        //Methods
        public void AddDept(params Department[] dept)
        {
            foreach(var d in dept)
            {
                if (deptCount < 10)
                    departments[deptCount++] = d;
                else
                    Console.WriteLine("Department Full!");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("University : " + name);
            for(int i=0; i<deptCount; i++)
            {
                departments[i].ShowInfo();
            }
        }

    }
}
