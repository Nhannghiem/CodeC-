using System;

namespace EmailProject
{
    public class ManagerLaptop
    {
        private string newProduct;
        private double newPrice;
        public int ID { get; set; }
        public double NewPrice
        {
            get
            {
                return newPrice;
            }
            set
            {
                newPrice = value;
            }
        }
        public string NewProduct
        {
            get
            {
                return newProduct;
            }
            set
            {
                newProduct = value;
            }
        }
        public ManagerLaptop(string newProduct, double newPrice)
        {
            NewPrice = newPrice;
            NewProduct = newProduct;
        }
        public void ShowProdut()
        {
            System.Console.WriteLine("Name Laptop : " + newProduct + " Price:  " + newPrice);
        }
    }
}