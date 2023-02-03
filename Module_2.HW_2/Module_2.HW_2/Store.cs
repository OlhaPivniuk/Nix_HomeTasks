using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2.HW_2
{
    internal class Store
    {
        private Product[] _products;
        public Store(int size)
        {
            _products = new Product[size];
        }
        public Product this[int index]
        {
            get
            {
                return _products[index];
            }
        }
        public void Add(Product em)
        {
            Product[] tmp = new Product[_products.Length + 1];
            int i;
            for (i = 0; i < _products.Length; i++)
                tmp[i] = _products[i];
            tmp[i] = em;
            _products = tmp;
        }
        public void FillDataByInitialization()
        {
            _products = new Product[10]
           {
                new Product ("Pants", 30920, 932),
                new Product ("Skirt", 86548, 832),
                new Product ("T-shirt", 45679, 259),
                new Product ("Socks", 47905, 45),
                new Product ("Shirt", 37904, 633),
                new Product ("Underpants", 36806, 169),
                new Product ("Coat", 25680, 3684),
                new Product ("Jacket", 47842, 4678),
                new Product ("Fur coat", 56892, 18999),
                new Product ("Robe", 12579, 1200),
           };
        }
        public void Print()
        {
            for (int i = 0; i < _products.Length; i++)
            {
                Console.Write(_products[i]);
                if (i < _products.Length - 1)
                {
                    Console.Write(",");
                }
            }
        }        
    }
}
