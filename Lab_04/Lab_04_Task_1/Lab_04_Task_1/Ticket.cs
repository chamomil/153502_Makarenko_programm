using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_04_Task_1
{
    public class Ticket
    {
        public Ticket(int n)
        {
            Price = n;
        }

        public int Price { get; private set; } 

        public void increase(int n)
        {
            Price += n;
        }

        public void decrease(int n)
        {
            Price -= n;
        }
    }
}