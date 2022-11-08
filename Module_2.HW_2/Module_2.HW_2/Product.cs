using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2.HW_2
{
    internal class Product
    {         
        public int Articul { get; set; }
        public string Name { get; set; }         
        public float Price { get; set; }  
              
        public Product()
        {
            Name = "Undefined";
        }
        public Product(string name, int code, float price)
        {
            Name = name; 
            Articul = code;             
            Price = price;            
        }
        public string GetName()
        {
            return Name;
        }
        public float GetPrice()
        {
            return Price;       
        }          
        public void Show()
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine($"Name of product: {Name}");
            Console.WriteLine($"Code of product: {Articul}");
            Console.WriteLine($"Price of product: {Price}$");            
            Console.WriteLine(new string('=', 50));
            Console.WriteLine();
        }
    }
}
