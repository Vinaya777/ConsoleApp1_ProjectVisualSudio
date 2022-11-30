using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio
{
    class AreaTriangle
    {
        static void Main(String[] args)
        {
            int b, h;
            Console.WriteLine("Enter the base ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height ");
            h = int.Parse(Console.ReadLine());
            double area = (b * h) * 0.5;
            Console.WriteLine("Area Of Traingle: " + area);

        }
    }
}
