using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_04_Task_1
{
    public class Airport
    {
        private static Airport? airport = null;
        private int seats;
        private int seld;

        Ticket ticket;

        private Airport(string nam, int seatss, int seldd, int pric) {
            Name = nam;
            seats = seatss;
            seld = seldd;
            ticket = new Ticket(pric);
            //ticket.SetPrice(pric);
        }

        public static Airport Creating(string nam = "My Airport", int seatss = 20, int seldd = 10, int price = 100)
        {
            if (airport == null) airport = new Airport(nam, seatss, seldd, price);
            return airport;
        }

        public string Name { get; set; }

        public int Sold_Seats()
        {
            int res = seld * ticket.Price;
            return res;
        }

        public void Increase_price( int n)
        {
            ticket.increase(n);
        }

        public void Decrease_price(int n)
        {
            ticket.decrease(n);
        }
    }
}