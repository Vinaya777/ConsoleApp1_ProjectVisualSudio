using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.Condition
{
    class PassingYearIfElsecs
    {

        static void Main(String[] args)
        {
            int year, marks;
            Console.WriteLine("Enter the Year");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks");
            marks = int.Parse(Console.ReadLine());

            if (year == 2022)
            {
                if (marks > 60)
                {
                    Console.WriteLine("Candidate Selected");

                }
                else
                {
                    Console.WriteLine("Below 60 marks Not Selected ");
                }

            }
            else
            {
                Console.WriteLine("No Candidate Selected");
            }
        }
    }
}
