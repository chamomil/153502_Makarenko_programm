using Xunit;
using task2;
using Task_02.Services;
using System;

namespace Test_02
{
    public class checkTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Task2.checkUp("12,1"));
        }
        [Fact]
        public void Test2()
        {
            Assert.True(Task2.checkUp("0"));
        }
        [Fact]
        public void Test3()
        {
            Assert.False(Task2.checkUp("jasgdvja"));
        }
    }
    public class FuncTest
    {
        public bool DoubleEquals(double left, double right)
        {
            return Math.Abs(left - right) < 1E-5;
        }
        [Fact]
        public void Test1()
        {
            Assert.True(DoubleEquals(ClassGet.Func(1.2), -0.445564));
        }
        [Fact]
        public void Test2()
        {
            Assert.False(DoubleEquals(ClassGet.Func(7), -0.445564));
        }
    }
}