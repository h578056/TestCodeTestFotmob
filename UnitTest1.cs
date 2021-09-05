using CodeTestFotmob;
using System;
using Xunit;

namespace TestCodeTestFotmob
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("10-100", "20-30" , "10-19, 31-100")]
        [InlineData("50-5000, 10-100", "", "10-5000")]
        [InlineData("10-100, 200-300", "95-205", "10-94, 206-300")]
        [InlineData("10-100, 200-300, 400-500", "95-205, 410-420", "10-94, 206-300, 400-409, 421-500")]
        [InlineData("10-100, 200-300, 400-500", " 9-205, 410-420", "206-300, 400-409, 421-500")]
        [InlineData("10-100", "9-30", "31-100")]
        [InlineData("10-100", "20-101", "10-19")]
        [InlineData("10-100", "20-100", "10-19")]
        [InlineData("10-100, 200-300, 400-500", " 9-205, 410-500", "206-300, 400-409")]
        public void TestIntervals(string inc, string exc, string expected)
        {
            Program p = new Program();
            Assert.Equal(expected, p.Interval(inc, exc));
        }
    }
}
