using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    public class Airport
    {
        List<Tariff> tariffs;

        public Airport()
        {
            tariffs = new List<Tariff>();
        }

        public List<Tariff> GetList()
        {
            return tariffs;
        }

        public void AddTariffWithDiscount(string name, double cost)
        {
            Tariff tar = new Tariff(name, cost, new Disco());
            tariffs.Add(tar);
        }

        public void AddTariffWithoutDisco(string name, double cost)
        {
            Tariff tar = new Tariff(name, cost, new NoDisco());
            tariffs.Add(tar);
        }

        public string MaxPrice()
        {
            if (tariffs.Count == 0) return String.Empty;
            double maxpric = 0;
            string res = "";
            for (int i = 0; i < tariffs.Count; ++i)
            {
                if (tariffs[i].GetPrice() > maxpric)
                {
                    maxpric = tariffs[i].GetPrice();
                    res = tariffs[i].GetName();
                }
            }
            return res;
        }
    }
}
