using System;

namespace EmailProject
{
    public class Shiper : ComputerSystem
    {
        public override void ChangeProduct(Client c, ManagerLaptop m)
        {
            if(m.NewProduct == ""){
                System.Console.WriteLine("Haven't Product");
            }else{
                System.Console.WriteLine("Recipient's name: " + c.Name);
                if(m.NewPrice >= c.Price){
                    m.NewPrice -= c.Price;
                    System.Console.WriteLine("Total amount Client need to pay more " + m.NewPrice);
                    System.Console.WriteLine("Name Change Product  " + m.NewProduct);
                }else{
                    c.Price -= m.NewPrice;
                    System.Console.WriteLine("Total amount Shiper need to pay more " + c.Price);
                    System.Console.WriteLine("Name Change Product" + m.NewProduct);
                }

            }
        }

        
    }
}