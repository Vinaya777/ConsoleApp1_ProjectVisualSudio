using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.Dowhile
{
    class OperationDowhile
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                int num1, num2;
                char op;
                Console.WriteLine("Enter the number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number");
                num2 = int.Parse(Console.ReadLine());



                Console.WriteLine("(+)Add");
                Console.WriteLine("(-)Sub");
                Console.WriteLine("(*)Multi");
                Console.WriteLine("(/)Division");
                Console.WriteLine("(%)Mod");
                op = Convert.ToChar(Console.ReadLine());
                switch (op)
                {
                    case '+':
                        Console.WriteLine("Addition" + (num1 + num2));
                        break;
                    case '-':
                        Console.WriteLine("Sub" + (num1 - num2));
                        break;
                    case '*':
                        Console.WriteLine("Multi" + (num1 * num2));
                        break;
                    case '/':
                        Console.WriteLine("Division" + (num1 / num2));
                        break;
                    case '%':
                        Console.WriteLine("Addition" + (num1 % num2));
                        break;

                }

                Console.WriteLine("Do You Want To Continue!!!!!");
                ch = Convert.ToChar(Console.ReadLine());


            } while (ch == 'y' || ch == 'Y');
        }
    }
}