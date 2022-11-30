using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ClassAndObjApproch
{
    class Car
    {
        String model_num; int price;
        String colour;

        void acceptDetails(String n,int q,String c)
        {
           this. model_num = n;
           this. price = q;
           this. colour = c;

        }
        void showDetails()
        {
            Console.WriteLine("Car Model Number" + model_num +  "Car Price"  + price +  "Colour"  + colour);
           
         
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Calling Details for Car  ");
            Car c = new Car();
            c.acceptDetails("XUV500", 1491000, "Black");
            c.showDetails();
            Car c1 = new Car();
            c1.acceptDetails("Tata Altroz", 635000, "Grey");
            c1.showDetails();
            Car c2 = new Car();
            c2.acceptDetails("Thar AX -4 str", 1359000, "Rocky beige");
            c2.showDetails();
            
            
       
            
        }
    }
}
