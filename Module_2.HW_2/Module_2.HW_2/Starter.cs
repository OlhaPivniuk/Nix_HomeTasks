using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2.HW_2
{
    public class Starter
    {        
        public void Run()
        {            
            Product p1 = new Product("Skirt", 86548, 832);
            Product p2 = new Product("Coat", 25680, 3684);
            Product p3 = new Product("Fur coat", 56892, 18999);
            Product p4 = new Product("Socks", 47905, 45);         

            ShoppingCart myCart = new ShoppingCart();

            myCart.AddProduct(p1);
            myCart.AddProduct(p2);
            myCart.AddProduct(p3);
            myCart.AddProduct(p4);

            myCart.ShowProduct();

            Order myOrder = new Order();
            myOrder.OrderId = 45667;
            Console.WriteLine($"Your order has been created with a number {myOrder.OrderId}");
        }
    }
}
