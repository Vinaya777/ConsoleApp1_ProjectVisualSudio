using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.NewFolder.Loop
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Operation To Perform");
            Console.WriteLine(" 1. Addition ");
            Console.WriteLine(" 2. Substraction ");
            Console.WriteLine(" 3. Division  ");
            Console.WriteLine(" 4. Multiplication ");
            Console.WriteLine(" 5.  Modulas");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Input");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Input");
            int input2 = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Addition" + (input1 + input2));
                    break;
                case 2:
                    Console.WriteLine("Substraction" + (input1 - input2));
                    break;
                case 3:
                    Console.WriteLine("Multiplication" + (input1 * input2));
                    break;
                case 4:
                    Console.WriteLine("Division" + (input1 / input2));
                    break;
                case 5:
                    Console.WriteLine("Modulas" + (input1 % input2));
                    break;
                default:
                    Console.WriteLine("Wrong input!!!!!! Try Again");
                    Console.WriteLine("Do You Want To Continue : : (Y/N)");
                   /* String s = Convert.ToString(Console.ReadLine());*/
                    Console.WriteLine(input1>input2 ? 'Y' : 'N');
                    break;




            }
        }
    }
}
