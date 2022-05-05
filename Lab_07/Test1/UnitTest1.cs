using Xunit;
using System;

namespace Lab_07
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Equation first = new Equation(1, -4, 4);
            Assert.Equal(-4, first[1]);
        }

        [Fact]
        public void Test2()
        {
            Equation second = new Equation(1, 1, -20);
            Assert.Equal(-20, second[2]); 
        }

        [Fact]
        public void Test3()
        {
            Equation second = new Equation(1, 1, -20);
            second = second + 1;
            Assert.Equal(-19, second[2]); 
        }

        [Fact]
        public void Test4()
        {
            Equation second = new Equation(1, 1, -20);
            second = second - 1;
            Assert.Equal(-21, second[2]);
        }

        [Fact]
        public void Test5()
        {
            Equation third = new Equation(0, 5, -10);
            ++third;
            Assert.Equal(6, third[1]);
        }

        [Fact]
        public void Test6()
        {
            Equation third = new Equation(0, 5, -10);
            --third;
            Assert.Equal(4, third[1]);
        }

        [Fact]
        public void Test7()
        {
            Equation first = new Equation(1, -4, 4);
            first = first * 2;
            Assert.Equal(-8, first[1]);
        }

        [Fact]
        public void Test8()
        {
            Equation first = new Equation(1, -4, 4);
            first = first / 2;
            Assert.Equal(-2, first[1]);
        }

        [Fact]
        public void Test9()
        {
            Equation first = new Equation(1, -4, 4);
            Equation third = new Equation(0, 5, -10);
            Assert.False(first == third);
        }

        [Fact]
        public void Test10()
        {
            Equation first = new Equation(1, -4, 4);
            Equation third = new Equation(1, -4, 4);
            Assert.True(first == third);
        }

        [Fact]
        public void Test11()
        {
            Equation first = new Equation(1, -4, 4);
            bool t = false;
            if (first) t = true;
            Assert.True(t);
        }

        [Fact]
        public void Test12()
        {
            Equation first = new Equation(0, 0, 4);
            bool t = true;
            if (first) t = false;
            Assert.True(t);
        }

        [Fact]
        public void Test13()
        {
            Equation first = new Equation(1, -4, 4);
            int k = (int)first + 10;
            Assert.Equal(11, k);
        }

        [Fact]
        public void Test14()
        {
            int k = 11;
            Equation first = (Equation)k;
            Assert.Equal(11, first[0]);
        }
    }
}