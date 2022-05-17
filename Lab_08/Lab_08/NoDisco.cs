using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    public class NoDisco : IDiscount
    {
        public double GetDiscount(double price)
        {
            return price;
        }
    }
}
