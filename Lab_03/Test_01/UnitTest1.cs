using Xunit;
using System;
using Task1N;
using Task_01;

namespace Test_01
{
    public class checkTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Task1.checkUp("12,1"));
        }
        [Fact]
        public void Test2()
        {
            Assert.True(Task1.checkUp("0"));
        }
        [Fact]
        public void Test3()
        {
            Assert.False(Task1.checkUp("jasgdvja"));
        }
    }
    public class FTest
    {
        public bool DoubleEquals(double left, double right)
        {
            return Math.Abs(left - right) < 1E-5;
        }
        [Fact]
        public void Test1()
        {
            Assert.True(DoubleEquals(ClassGet.f(Math.PI / 6.0), 0));
        }
        [Fact]
        public void Test2()
        {
            Assert.True(DoubleEquals(ClassGet.f(Math.PI / 2.0), 0));
        }
        [Fact]
        public void Test3()
        {
            Assert.False(DoubleEquals(ClassGet.f(Math.PI / 5.0), 0));
        }
    }
    public class MinTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(ClassGet.min(Math.PI / 6.0, 2), 1);
        }
        [Fact]
        public void Test2()
        {
            Assert.Equal(ClassGet.min(2, 9), 2);
        }
        [Fact]
        public void Test3()
        {
            Assert.Equal(ClassGet.min(2, 2), 0);
        }
    }
}