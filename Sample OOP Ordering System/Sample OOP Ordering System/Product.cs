using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_OOP_Ordering_System
{
    class Product
    {
        private String name;
        private int ID;
        private double price;
        public Product(String name, int ID, double price)
        {
            this.SetName(name);
            this.SetID(ID);
            this.SetPrice(price);
        }
        public String GetName()
        {
            return name;
        }
        public void SetName(String name)
        {
            this.name = name;
        }
        public int GetID()
        {
            return ID;
        }
        public void SetID(int ID)
        {
            this.ID = ID;
        }
        public double GetPrice()
        {
            return price;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }
    }
}
