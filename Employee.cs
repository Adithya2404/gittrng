using System;
using System.Collections.Generic;
using System.Text;

namespace linqPractice
{
    public class Employee
    {
        public Employee()
        {

        }

        public Employee(int id, string name, string dept)
        {
            this.ID = id;
            this.Name = name;
            this.Dept = dept;

        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
    }

    public class Department
    {

        public Department()
        {

        }
        public Department(string dept, string manager)
        {
            this.Dept = dept;
            this.Manager = manager;

        }
        public string Dept { get; set; }
        public string Manager { get; set; }
    }
}
