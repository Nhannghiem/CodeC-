using System;
namespace EmailProject
{
    public abstract class ComputerSystem
    {
        public ComputerSystem Next{get; set;}
        public abstract void ChangeProduct(Client c, ManagerLaptop m);

    }
}