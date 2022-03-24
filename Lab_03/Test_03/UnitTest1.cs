using Xunit;
using task3;
using Task_03;
using System;

namespace Test_03
{
    public class checkTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Task3.checkUp("12.10.03"));
        }
        [Fact]
        public void Test2()
        {
            Assert.True(Task3.checkUp("21 06 12"));
        }
        [Fact]
        public void Test3()
        {
            Assert.False(Task3.checkUp("jasgdvja"));
        }
    }
    public class GetDayTest
    {
        [Fact]
        public void Test1()
        {
            DateTime dat5 = new DateTime(2003, 10, 4);
            Assert.Equal(DateService.GetDay(dat5), DayOfWeek.Saturday);
        }
        [Fact]
        public void Test2()
        {
            DateTime dat5 = new DateTime(2003, 10, 5);
            Assert.Equal(DateService.GetDay(dat5), DayOfWeek.Sunday);
        }
    }
    public class SpanTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(DateService.GetDaysSpan(24, 3, 2022), 0);
        }
        [Fact]
        public void Test2()
        {
            Assert.Equal(DateService.GetDaysSpan(23, 3, 2022), 1);
        }
    }
}