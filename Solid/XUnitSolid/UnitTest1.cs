using Solid;
using System;
using Xunit;

namespace XUnitSolid
{
    public class RectangleTests
    {
        [Fact]
        public void Test_Rectangle_Area()
        {
            // Arrange
            var sut = new Rectangle();
            sut.Width = 3;
            sut.Height = 6;
            var expected = 18d;

            //Act
            var actual = sut.Area();


            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
