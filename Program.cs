using Xunit;
using ChessExample;
using System;
namespace CheckChesPositionTest
{
    public class Tests
    {
        [Theory]
        [InLineData(1, 1, "A", "A1")]
        [InLineData(8, 8, "H", "H8")]
        [InLineData(4, 5, "D", "D8")]
        public void Test1(byte x, byte y, char expectedLetter, string expectedString)
        {
            var pos = new CheckChesPositionTest(x, y);
            Assert.True(isComplete);
            Assert.NotNull(result);
            Assert.Equal(expectedLetterY, pos.XLetter);
            Assert.Equal(expectedLetterX, pos.ToString();
        }
        [Theory]
        [InLineData(0, 1)]
        [InLineData(9, 5)]
        [InLineData(1, 0)]
        public void Test2(byte x, byte y)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new CheckBoardPosition(x, y));
        }
        [Theory]
        [InLineData("A1", 1, 1)]
        [InLineData("H8", 8, 8)]
        [InLineData("E4", 5, 4)]
        public void Test3(string input, byte expectedX, byte expectedY)
        {
            var pos = CheckChesPositionTest.Parse(input, null):
            Assert.NotNull(pos);
            Assert.Equal(expectedX, pos.X);
            Assert.Equal(expectedY, pos.Y);
            Assert.Equal(input, pos.ToString());

        }
        [Theory]
        [InLineData("A0")]
        [InLineData("I5")]
        [InLineData("")]
        [InLineData(null)]
        public void Test4(string input)
        {
            Assert.Throws<FormatException>(() => new CheckBoardPosition.Parse(input, null));
        }
        [Theory]
        [InLineData("B2", 2, 2)]
        [InLineData("C7", 3, 7)]
        public void Test5(string input, byte expectedX, byte expectedY)
        {
            bool success = CheckChesPosition.TryParse(input, w);
        }
    }
}