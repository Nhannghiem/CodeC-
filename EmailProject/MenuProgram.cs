using System.Collections.Generic;
using System;
namespace EmailProject
{
    public class MenuProgram
    {
        private ShopLaptop shop;

        public MenuProgram()
        {
            shop = new ShopLaptop();
        }
        public void Run()
        {
            while (true)
            {
                PrintMenu();
                int choice = GetChoice();
                DoTask(choice);
                if (choice == 0) break;
            }
        }
        private void PrintMenu()
        {
            System.Console.WriteLine("WELLCOME System Change Product ");
            System.Console.WriteLine(" 1. Choice product change ");
            System.Console.WriteLine(" 2. Add Products");
            System.Console.WriteLine(" 3. Edit Product ");
            System.Console.WriteLine(" 4. Show Product");
            System.Console.WriteLine(" 0. Quit");

        }
        private int GetChoice()
        {
            System.Console.WriteLine(" Enter Choice ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        private void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: ChangeProduct(); break;
                case 2: AddProduct(); break;
                case 3: EditProduct(); break;
                case 4: ShowLaptop(); break;
                case 0: break;
                default: Error(); break;


            }
        }

        private void Error()
        {
            System.Console.WriteLine(" Choice Invalid ");
            System.Console.WriteLine(" Choice Again ");
        }

        private void EditProduct()
        {
            shop.EditProduct();
        }

        private void ShowLaptop()
        {

            shop.ShowProdut();
        }
        private void AddProduct()
        {

            System.Console.WriteLine("Enter Name Producrts");
            string newProduct = Console.ReadLine();
            System.Console.WriteLine("Enter Price Products ");
            double newPrice = Convert.ToDouble(Console.ReadLine());

            ManagerLaptop m = new ManagerLaptop(newProduct, newPrice);
            
            shop.AddLaptop(m);
            
            m.ShowProdut();

        }

        private void ChangeProduct()
        {
            System.Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter Name Product");
            string product = Console.ReadLine();
            System.Console.WriteLine("Enter Price Product");
            double price  = Convert.ToDouble(Console.ReadLine());


            Client client = new Client(name, product, price);

            ManagerLaptop newLapt = new ManagerLaptop("", 0);


            Shiper s1 = new Shiper();

            ProductionStorage p1 = new ProductionStorage();
            p1.Next = s1;
            
            shop.Next = p1;

            shop.ChangeProduct(client, newLapt);
        }
    }
}