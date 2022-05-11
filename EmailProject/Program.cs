using System;

namespace EmailProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("System Laptop");
            

            ManagerLaptop m1 = new ManagerLaptop("Dell",20);
            ManagerLaptop m5 = new ManagerLaptop("Macboock",18.540);
            ManagerLaptop m2 = new ManagerLaptop("HTP",190000);
            // ManagerLaptop newLapt = new ManagerLaptop("" , 0);

            // // Shiper s1 = new Shiper();
            
            // // ProductionCompany p1 = new ProductionCompany();
            // // p1.Next = s1;
            
            // ShopLaptop lap = new ShopLaptop();
            // lap.AddLaptop(m1);
            // lap.AddLaptop(m2);
            // lap.AddLaptop(m5);

            // lap.ShowProdut();

            // // lap.Next = p1;
            
            
            // Client c = new Client("Nhan", "Dell", 17.899);

            // lap.ChangeProduct(c, newLapt); 

            MenuProgram m = new MenuProgram();
            m.Run();


        }
    }
}
