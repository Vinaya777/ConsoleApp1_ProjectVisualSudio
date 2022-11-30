using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.Condition
{
    class   Percentage
    {
        static void Main(String[] args)
        {
            float SoftwareEng,Networking, DigitalElectronics, ComputerFundamentals, TechnicalCommunicationSkill;
            Console.WriteLine("Enter Marks for SoftwareEng Subject ");
            SoftwareEng = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks for Networking Subject ");
            Networking = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks for DigitalElectronics Subject ");
            DigitalElectronics = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks for ComputerFundamentals Subject");
            ComputerFundamentals = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks for TechnicalCommunicationSkill Subject");
            TechnicalCommunicationSkill = int.Parse(Console.ReadLine());


            float total = SoftwareEng + Networking + DigitalElectronics+ ComputerFundamentals+ TechnicalCommunicationSkill;
            float per = total / 5;
            Console.WriteLine("Percentage: " + per + "%");

            if (per >= 70)
            {
                Console.WriteLine("Distiction");
            }
            else if (per<=60 && per >= 70)
            {
                Console.WriteLine("First Class");
            }
            else if(per<=50 && per >= 60)
            {
                Console.WriteLine("Second Class");

            }
            else if(per<=35 && per >= 50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }
    }
}
