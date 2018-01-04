using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_OOP_Ordering_System
{
    class Order
    {
        private String name;
        private int ID;
        private List<Double> prices = new List<Double>();
        public Order (String name, int ID)
        {
            this.SetName(name);
            this.SetID(ID);
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
        public void AddProduct(Product product)
        {
            prices.Add(product.GetPrice());
        }
        public double OrderPrice()
        {
            double total = 0;
            for(int i=0; i<prices.Count(); i++)
            {
                total += prices.ElementAt(i);
            }
            return total;
        }
        public void OrderDetails()
        {
            Console.WriteLine(GetName() + " has ordered " + prices.Count() + " items.");
        }
    }
}
