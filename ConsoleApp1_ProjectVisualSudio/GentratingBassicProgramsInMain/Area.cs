using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.GentratingBassicProgramsInMain
{
    class Area
    {
        public double AreaOfCircle(int r, double PI)
        {
            double area = PI * r * r;
            return area;
        }
        public void Addition(int x,float y)
        {
            float ans = x + y;
            Console.WriteLine("Ans=" + ans);
        }
        static void Main(string[] args)
        {
            Area a = new Area();
            double result = a.AreaOfCircle(4, 3.14);
            Console.WriteLine("Area : "+result);
            a.Addition(5, 3.4f);
        }
    }

    class FindCube
    {

      /* public int FindCube(int num1)
        {
            
            return (num1 * num1 * num1);
        }*/
        static void Main(string[] args)
        {/*
            FindCube fc = new FindCube();
            int result = fc.FindCube(3);
            Console.WriteLine("Cube Of Number="+result);*/
        }
    }
}
