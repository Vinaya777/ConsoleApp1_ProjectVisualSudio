using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.GentratingBassicProgramsInMain
{
    class MaxNumber
    {
      
        int max = 0;

        public void MaxNumbern(int n)
        {
          while (n != 0)
            {
                int r = n % 10;
                n/= 10;
                if (max < r)
                    max = r;
           }
            Console.WriteLine(" "+n);
           
        }
        static void Main(string[] args) 
        {

            Console.WriteLine("Enter the Number");
            int a = Convert.ToInt32(Console.ReadLine());
            MaxNumber mn = new MaxNumber();
            mn.MaxNumbern(a);
        }
                
            

     }
  }


