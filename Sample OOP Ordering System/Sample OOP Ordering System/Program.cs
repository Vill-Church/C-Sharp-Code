using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_OOP_Ordering_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order("Will", 1);
            Order order2 = new Order("Rosa", 2);
            Product product1 = new Product("Computer",1, 499.99);
            Product product2 = new Product("Mouse", 2, 5.99);
            Product product3 = new Product("Keyboard", 3, 11.99);
            order1.AddProduct(product2);
            order2.AddProduct(product1);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            order1.OrderDetails();
            Console.WriteLine(order1.GetName() + " owes a total of £" + order1.OrderPrice());
            order2.OrderDetails();
            Console.WriteLine(order2.GetName() + " owes a total of £" + order2.OrderPrice());
            Console.ReadLine(); // keep console open to check
        }
    }
}
