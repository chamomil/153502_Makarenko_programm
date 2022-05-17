using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    public interface IDiscount
    {
        public abstract double GetDiscount(double price);
    }
}
