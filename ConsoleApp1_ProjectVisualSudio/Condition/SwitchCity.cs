using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.Condition
{
    class SwitchCity
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the City");
            String city = Console.ReadLine();
            switch (city)
            {
                case "Pune":Console.WriteLine("Welcome to Pune");
                    break;
                case "Mummbai":Console.WriteLine("Welcome to Mummbai");
                    break;
                case "Delhi":Console.WriteLine("Welcome to Delhi");
                    break;
                case "Bengluru": Console.WriteLine("Welcome to Bengluru");
                    break;
                default:
                    Console.WriteLine("Enter the Other City/Invalid City");
                    break;
            }
        }
    }
}
