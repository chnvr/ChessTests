using Xunit;
using ChessExample;
using System;
namespace CheckerChessPositionTest
{
    public class Tests
    {
        [Theory]
        [InlineData(1, 1, "A", "A1")]
        [InlineData(8, 8, "H", "H8")]
        [InlineData(4, 5, "D", "D5")]
        public void Test1(byte x, byte y, char expectedLetter, string expectedString)
        {
            var pos = new CheckerBoardPosition(x, y);
            Assert.True(x, pos X);
            Assert.NotNull(y, pos Y);
            Assert.Equal(expectedLetter, pos.XLetter);
            Assert.Equal(expectedLetter, pos.ToString();
        }
        [Theory]
        [InlineData(0, 1)]
        [InlineData(9, 5)]
        [InlineData(1, 0)]
        public void Test2(byte x, byte y)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new CheckerBoardPosition(x, y));
        }
        [Theory]
        [InlineData("A1", 1, 1)]
        [InlineData("H8", 8, 8)]
        [InlineData("E4", 5, 4)]
        public void Test3(string input, byte expectedX, byte expectedY)
        {
            var pos = CheckerBoardPosition.Parse(input, null):
            Assert.NotNull(pos);
            Assert.Equal(expectedX, pos.X);
            Assert.Equal(expectedY, pos.Y);
            Assert.Equal(input, pos.ToString());

        }
        [Theory]
        [InlineData("A0")]
        [InlineData("I5")]
        [InlineData("")]
        [InlineData(null)]
        public void Test4(string input)
        {
            Assert.Throws<FormatException>(() => new CheckerBoardPosition.Parse(input, null));
        }
        [Theory]
        [InlineData("B2", 2, 2)]
        [InlineData("C7", 3, 7)]
        public void Test5(string input, byte expectedX, byte expectedY)
        {
            bool success = CheckerBoardPosition.TryParse(input, null, out var pos);
            Assert.True(success);
            Assert.NotNull(pos);
            Assert.Equal(expectedX, pos.X);
            Assert.Equal(expectedY, pos.Y);
        }
        [Theory]
        [InlineData("Z1")]
        [InlineData("A")]
        [InlineData("")]
        [InlineData(null)]
        public void Test6(string input)
        {
            bool sucess = CheckerBoardPosition.TryParse(input, null, out var pos);
            Assert.True(success);
            Assert.NotNull(pos);
        }
    }
}
