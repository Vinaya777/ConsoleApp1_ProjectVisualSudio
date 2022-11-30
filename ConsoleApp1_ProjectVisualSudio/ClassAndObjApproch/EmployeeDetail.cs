using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ClassAndObjApproch
{
    class EmployeeDetail
    {
        private int id;
        private String name;
        private float salary;


        public int getId()
        {
            return id;
        }
        public String getName()
        {
            return name;
        }
        public float getSalary()
        {
            return salary;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setSalary(float salary)
        {
            this.salary = salary;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Employee Details");
            EmployeeDetail ed = new EmployeeDetail();

            Console.WriteLine("Emp ID");
            int ed1 = int.Parse(Console.ReadLine());
            ed.setId(ed1);
            Console.WriteLine("Employe ID: "+ed.getId());

            Console.WriteLine("Emp Name");
            int ed2 = int.Parse(Console.ReadLine());
            ed.setId(ed2);
            Console.WriteLine("Employe Name: " + ed.getName());

            Console.WriteLine("Emp Salary");
            int ed3 = int.Parse(Console.ReadLine());
            ed.setId(ed3);
            Console.WriteLine("Employe Salary: " + ed.getSalary());


        }
    }
}
