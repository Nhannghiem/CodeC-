using System;
namespace EmailProject
{
    public class Client
    {
        private string name;
        
        private double price;
        private string product;

        public double Price{
            get {return price;}
            set{
                if(value < 0 ){
                    System.Console.WriteLine("Invalid");
                }
                price = value;
            }
        }
        public string Product{
            get {return product;}
            set{
                if(value == "" ){
                    System.Console.WriteLine("Invalid");
                }
                product = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == "")
                {
                    System.Console.WriteLine("Invalid");
                }
                    name = value;
                
            }
        }
        public Client(){
            name= "Name";
            price = 0;
            product = "No Product";
        
        }
        public Client(string name, string product, double price)
        {
            Product = product;
            Price = price;   
            Name = name;
        }
    }
}