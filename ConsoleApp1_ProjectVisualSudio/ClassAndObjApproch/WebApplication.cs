using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ClassAndObjApproch
{
    class WebApplication
    {
        int ac;
        string name;
        public void insert(int ac,string name)
        {
            this.ac = ac;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("AccountId"+ ac +"Name"+name);
        }

        static void Main(string[] args)
        {
            WebApplication wa = new WebApplication();
            wa.insert(25, "Max");
            wa.display();


        }
    }
}
