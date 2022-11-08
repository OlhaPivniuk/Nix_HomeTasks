using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2.HW_2
{
    internal class ShoppingCart
    {
        private const int ArraySize = 10;
        private Product[] _products = new Product[ArraySize];
        
        public DateTime CreateDateTime { get; set; }
        public User User { get; private set; }
        private Product Product { get; set; }
        private int Quantity { get; set; }
        public float TotalValue { get; set; }             
        
        public void AddProduct(Product product)
        {
            _products[Quantity] = product;
            Quantity++;

            if (Quantity == _products.Length)
            {
                Array.Resize(ref _products, Quantity + ArraySize);
            }
        }
        public void ShowProduct()
        {
            if (_products != null)
            {
                foreach (Product item in _products)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{item.Articul}, {item.Name}, {item.Price}");
                }
                ShowTotal();
            }
        }        
        public void ShowTotal()
        {
            if (_products != null)
            {
                TotalValue = 0;

                foreach (Product item in _products)
                {
                    TotalValue += item.Price;
                }
                Console.WriteLine();
                Console.WriteLine($"Total from shopping cart is: ${TotalValue.ToString("F")}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Your shopping cart is empty and has no items");
            }
        }
    }
}