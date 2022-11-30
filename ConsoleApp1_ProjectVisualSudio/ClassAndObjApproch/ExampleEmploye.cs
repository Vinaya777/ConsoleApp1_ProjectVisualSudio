using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ClassAndObjApproch
{
    class ExampleEmploye
    {
        int id;
        String name;
        double marks;
        public void Acceptdetails(int sid,string sname,double mark)
        {
            id = sid;
            name = sname;
            marks = mark;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + marks);
        }
        static void Main(string[] args)
        {
            ExampleEmploye exemp = new ExampleEmploye();
            exemp.Acceptdetails(100,"xyz",78.54);
            exemp.display();


        }
    }
}
