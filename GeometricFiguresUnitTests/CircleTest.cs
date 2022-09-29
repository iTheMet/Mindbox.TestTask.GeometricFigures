using GeometricFigures;
using System;
using Xunit;

namespace GeometricFiguresUnitTests
{
    public class CircleTest
    {
        [Fact]
        public void ValidationOfProperties()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0).GetArea());
            Assert.Throws<ArgumentException>(() => new Circle(-1).GetArea());
        }


        [Fact]
        public void GetAreaTest()
        {
            Assert.Equal(Math.PI, new Circle(1).GetArea());
            Assert.Equal(Math.PI * 4, new Circle(2).GetArea());
        }
    }
}
