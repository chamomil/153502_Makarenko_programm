using Xunit;

namespace Lab_06
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Car car = new Toyota();
            Assert.Equal("Base", car.Met());
            Toyota toyota = (Toyota)car;
            Assert.Equal("Child", toyota.Met());

            Assert.Equal("toyota", toyota.GetBrand());
            Assert.Equal("white", toyota.GetColour());

            BMW bmw = new BMW();
            Assert.Equal("BMW", bmw.GetBrand());
            Assert.Equal("black", bmw.GetColour());
        }
    }
}