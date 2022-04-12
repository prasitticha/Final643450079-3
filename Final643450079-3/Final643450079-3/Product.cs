using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final643450079_3
{
    internal class Product
    {
        private string name;
        private double price;

        public Product(string name, int price)
        {
            name = name;
            price = price;
        }
        public double getPrice()
        {
            return price;
        }
    }
}
