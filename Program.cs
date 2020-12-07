using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace linqPractice
{

    class program
    {
        private static List<Employee> GetListofEmployees()
        {
            List<Employee> emps = new List<Employee>();
            emps.Add(new Employee(1, "John", "Trainer"));
            emps.Add(new Employee(2, "Mark", "Finance"));
            emps.Add(new Employee(3, "Peter", "Technical"));
            emps.Add(new Employee(4, "Bob", "Admin"));
            emps.Add(new Employee(5, "Robert", "Finance"));
            emps.Add(new Employee(6, "Robert", "Trainer"));

            return emps;
        }
        private static List<Department> GetListofDepartment()
        {
            List<Department> depts = new List<Department>();
            depts.Add(new Department("Trainer", "Karthika"));
            depts.Add(new Department("Finance", "Kavitha"));
            depts.Add(new Department("Technical", "Latha"));
            depts.Add(new Department("HR", "Madhavi"));
            return depts;
        }
        public static void SampleEmployeeList()
        {

            List<Department> depts = GetListofDepartment();
            List<Employee> emps = GetListofEmployees();

            //var emp_query = from Employee in emps
            //                where Employee.Dept == "Technical"
            //                select Employee;

            //var emp_query = from employee in emps
            //                join dept in depts                                             // joins
            //                on employee.Dept equals dept.Dept
            //                select new { Name = employee.Name, Manager = dept.Manager };
            //foreach (var item in emp_query)
            //{
            //    //Console.WriteLine(item.departments);
            //    foreach (var n in emp_query)
            //    {
            //        Console.WriteLine($"{n.Name}'s manager is {n.Manager}");
            //    }
            //}

            var emp_query = from employee in emps
                            group employee by employee.Dept into g             // GROUP BYS
                            select new { DeptName = g.Key, emps = g };

            foreach (var item in emp_query)
            {
                Console.WriteLine($"In dept {item.DeptName}");
                Console.WriteLine($"Employees are {item.emps.Count()}");
                foreach (var e in item.emps)
                {
                    Console.WriteLine(e.Name);
                }
            }


            //var emp_query = from E in emps
            //                group E.Name by E.Dept into g
            //                select new { departments = g.Key, names = g };
            //var emp_query = from employee in emps
            //                group employee by employee.Dept into g
            //                select new {​​​​ DeptName = g.Key, emps = g }​​​​;
            
            
        }

        public static void Main()
        {
            SampleEmployeeList();
        }
    }

}