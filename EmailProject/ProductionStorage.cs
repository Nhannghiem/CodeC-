using System.Security.Cryptography;
using System;
namespace EmailProject
{
    public class ProductionStorage : ComputerSystem
    {


        private int i = 100;

        public override void ChangeProduct(Client c, ManagerLaptop m)
        {
            if (m.NewProduct == "")
            {
                System.Console.WriteLine("Sorry No Product");
            }
            else
            {
                System.Console.WriteLine("Product Company");
                m.ID = i++;
                string v = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                System.Console.WriteLine("Product packing date: " + v);
                System.Console.WriteLine("Product ID " + m.ID);
                System.Console.WriteLine("Product " + m.NewProduct);
                System.Console.WriteLine("Price " + m.NewPrice);

                System.Console.WriteLine("Next Shiper...");
                Next.ChangeProduct(c, m);
            }





        }
    }
}