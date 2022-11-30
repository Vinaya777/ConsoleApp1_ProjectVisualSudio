using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ClassAndObjApproch
{
    class AdditionAndSub
    {
        int a, b;
        public void display()
        {
            Console.WriteLine("Display Method");
        }
        public void add()
        {
            Console.WriteLine("In Add Method" + (a + b));
        }
        public void sub()
        {
            Console.WriteLine("Substraction " + (a - b));
           
        }
        static void Main(string[] args)
        {
            AdditionAndSub ads = new AdditionAndSub();
            ads.display();
            ads.add();
            ads.sub();
            


            
        }
    }
}
