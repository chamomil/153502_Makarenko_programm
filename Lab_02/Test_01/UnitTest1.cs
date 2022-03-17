using Xunit;
using static lessons.Program;

namespace Test_01
{
    public class UnitTest1_check
    {
        [Fact]
        public void Test1()
        {
            Assert.True(check("7712"));
        }
        [Fact]
        public void Test2()
        {
            Assert.False(check("-7712"));
        }
        [Fact]
        public void Test3()
        {
            Assert.False(check("gfhfh"));
        }
        [Fact]
        public void Test4()
        {
            Assert.False(check("77.12"));
        }
        [Fact]
        public void Test5()
        {
            Assert.True(check("6237"));
        }
    }

    public class UnitTest2_secCheck
    {
        [Fact]
        public void Test1()
        {
            Assert.True(secCheck("Y"));
        }
        [Fact]
        public void Test2()
        {
            Assert.False(secCheck("-7712"));
        }
        [Fact]
        public void Test3()
        {
            Assert.False(secCheck("gfhfh"));
        }
        [Fact]
        public void Test4()
        {
            Assert.False(secCheck("77.12"));
        }
        [Fact]
        public void Test5()
        {
            Assert.True(secCheck("N"));
        }
    }

    public class UnitTest3_seven
    {
        [Fact]
        public void Test1()
        {
            Assert.False(endsWithSeven("77.12"));
        }
        [Fact]
        public void Test2()
        {
            Assert.True(endsWithSeven("7"));
        }
        [Fact]
        public void Test3()
        {
            Assert.False(endsWithSeven("hsjhag"));
        }
        [Fact]
        public void Test4()
        {
            Assert.True(endsWithSeven("77777767"));
        }
    }
}