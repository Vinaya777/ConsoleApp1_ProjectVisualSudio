using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.NewFolder.MCQ
{
    class mcq2
    {
        static void Main(string[] args)
        {
            int n1 = 2,n2 = 5,n3 = 10;
            String m = n1 >= n2 && n1 >= n3 ? n1 + " is maximum" : n2 >= n1 && n2 >= n3 ? n2 + " is maximum" : n3 + " is maximum";
            Console.WriteLine(m);
        }
    }
}
