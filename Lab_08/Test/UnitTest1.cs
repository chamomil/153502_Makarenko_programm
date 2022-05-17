using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    public class UnitTest1
    {
        public bool DoubleEquals(double left, double right)
        {
            return Math.Abs(left - right) < 1E-4;
        }

        [Fact]
        public void Test1()
        {
            Airport airport = new Airport();
            airport.AddTariffWithoutDisco("Japan", 50.0);
            Assert.Equal("Japan", airport.MaxPrice());
        }

        [Fact]
        public void Test2()
        {
            Airport airport = new Airport();
            airport.AddTariffWithDiscount("USA", 150.0);
            Assert.Equal("USA", airport.MaxPrice());
        }

        [Fact]
        public void Test3()
        {
            Airport airport = new Airport();
            airport.AddTariffWithDiscount("France", 100.0);
            airport.AddTariffWithoutDisco("Germany", 40.0);
            Assert.Equal("France", airport.MaxPrice());
        }

        [Fact]
        public void Test4()
        {
            Airport airport = new Airport();
            List<Tariff> tar = airport.GetList();
            airport.AddTariffWithDiscount("France", 100.0);
            airport.AddTariffWithoutDisco("Germany", 60.0);
            Assert.True(DoubleEquals(tar[0].GetPrice(), 50.0));
            Assert.True(DoubleEquals(tar[1].GetPrice(), 60.0));
        }
    }
}