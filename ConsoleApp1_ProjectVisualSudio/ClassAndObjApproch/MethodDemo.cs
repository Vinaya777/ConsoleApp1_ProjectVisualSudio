using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ClassAndObjApproch
{
    class MethodDemo
    {
        public void show()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            MethodDemo md = new MethodDemo();
            md.show();
        }
    }
}
