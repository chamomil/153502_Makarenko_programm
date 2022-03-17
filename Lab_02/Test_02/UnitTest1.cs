using Xunit;
using lessons;

namespace Test_02
{
    public class UnitTest1_checkUp
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Program2.checkUp("62,12"));
        }
        [Fact]
        public void Test2()
        {
            Assert.False(Program2.checkUp("62,12.hhh"));
        }
        [Fact]
        public void Test3()
        {
            Assert.False(Program2.checkUp("asg-222,1"));
        }
        [Fact]
        public void Test4()
        {
            Assert.True(Program2.checkUp("100"));
        }
    }

    public class UnitTest2_secCheck
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Program2.secCheck("Y"));
        }
        [Fact]
        public void Test2()
        {
            Assert.False(Program2.secCheck("-7712"));
        }
        [Fact]
        public void Test3()
        {
            Assert.False(Program2.secCheck("gfhfh"));
        }
        [Fact]
        public void Test4()
        {
            Assert.False(Program2.secCheck("77,12"));
        }
        [Fact]
        public void Test5()
        {
            Assert.True(Program2.secCheck("N"));
        }
    }

    public class UnitTest3_inArea
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Program2.inArea(-5, -5));
        }
        [Fact]
        public void Test2()
        {
            Assert.False(Program2.inArea(100, 1));
        }
        [Fact]
        public void Test3()
        {
            Assert.True(Program2.inArea(-5, -7));
        }
        [Fact]
        public void Test4()
        {
            Assert.False(Program2.inArea(-7, 5));
        }
    }

    public class UnitTest4_border
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Program2.border(-5, -5));
        }
        [Fact]
        public void Test2()
        {
            Assert.False(Program2.border(100, 1));
        }
        [Fact]
        public void Test3()
        {
            Assert.True(Program2.border(0, -25));
        }
        [Fact]
        public void Test4()
        {
            Assert.False(Program2.border(-7, 5));
        }
        [Fact]
        public void Test5()
        {
            Assert.True(Program2.border(-15, -20));
        }
    }
}