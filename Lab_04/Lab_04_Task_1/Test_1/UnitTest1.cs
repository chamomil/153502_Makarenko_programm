using Xunit;
using Lab_04_Task_1;

namespace Test_1
{
    public class UnitTest1
    {
        
        [Fact]
        public void Test1()
        {
            Airport air = Airport.Creating();
            Assert.Equal(air.Name, "My Airport");
            Assert.Equal(1000, air.Sold_Seats());
            air.Increase_price(100);
            Assert.Equal(2000, air.Sold_Seats());
            air.Decrease_price(200);
            Assert.Equal(0, air.Sold_Seats());
            Assert.Equal(air, Airport.Creating("lalal", 30, 1, 90));
        }

    }
}