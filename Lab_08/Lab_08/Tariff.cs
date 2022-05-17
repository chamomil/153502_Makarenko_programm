using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    public class Tariff
    {
        string name;
        IDiscount discount;
        double price;

        public string GetName()
        {
            return name;
        }

        public Tariff(string name, double price, IDiscount discount)
        {
            this.name = name;
            this.price = price;
            this.discount = discount;
        }

        public double GetPrice()
        {
            return discount.GetDiscount(price);
        }
    }
}