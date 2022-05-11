using System.Collections.Generic;
using System;
namespace EmailProject
{
    public class ShopLaptop : ComputerSystem
    {
        public List<ManagerLaptop> managers;
        public ShopLaptop()
        {
            managers = new List<ManagerLaptop>();
        }

        public void AddLaptop(ManagerLaptop m)
        {
            managers.Add(m);
        }


        public override void ChangeProduct(Client c, ManagerLaptop newLaptop)
        {
            System.Console.WriteLine("Name " + c.Name);
            System.Console.WriteLine("Do you want to Change product y/n ?");
            string imput = Console.ReadLine();


            if (imput == "y")
            {
                ShowProdut();

                System.Console.WriteLine("Choice Product"); 
                string name = Console.ReadLine();
                foreach (ManagerLaptop laptop in managers)
                {
                    if (laptop.NewProduct == name)
                    {
                        System.Console.WriteLine("Product: " + laptop.NewProduct + " Price: " + laptop.NewPrice);
                        newLaptop.NewProduct = laptop.NewProduct;
                        newLaptop.NewPrice = laptop.NewPrice;

                        System.Console.WriteLine("Next Product Storage...");
                        Next.ChangeProduct(c, newLaptop);
                        
                    }
                }
            }
            else
            {
                System.Console.WriteLine("Sorry");
            }
        }
        public void ShowProdut()
        {
            foreach (ManagerLaptop m in managers)
            {
                m.ShowProdut();
            }
        }

        public void EditProduct()
        {
            System.Console.WriteLine("ENTER PRODUCT NAME");
            string a = Console.ReadLine();
            foreach (ManagerLaptop mana in managers)
            {
                if (mana.NewProduct == a)
                {
                
                    System.Console.WriteLine("Edit New Product Name");
                    string name = Console.ReadLine();
                    System.Console.WriteLine("Edit Product Price");
                    double price = Convert.ToDouble(Console.ReadLine());

                    mana.NewProduct = name;
                    mana.NewPrice = price;

                    System.Console.WriteLine("Product: " + mana.NewProduct + " Price: " + mana.NewPrice);
                    System.Console.WriteLine("*-----Edit Product Successfully!-----* ");
                    
                } else{
                    System.Console.WriteLine("No Product");
                }
                
            }
        }
    }
}