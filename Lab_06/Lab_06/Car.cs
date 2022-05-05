using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public abstract class Car
    {
        protected string? model;

        public string? Met()
        {
            return "Base";
        }
        public Car()
        {
            Console.WriteLine("constructor of the class Car was called");
        }

        abstract public string GetBrand();
        virtual public string GetColour()
        {
            return "black";
        }
    }
}
