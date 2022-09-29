using GeometricFigures;
using System;
using Xunit;

namespace GeometricFiguresUnitTests
{
    public class TriangleTest
    {
        [Fact]
        public void ValidationOfProperties()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 0).GetArea());
            Assert.Throws<ArgumentException>(() => new Triangle(1, 0, 1).GetArea());
            Assert.Throws<ArgumentException>(() => new Triangle(0, 1, 1).GetArea());

            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, -1).GetArea());
            Assert.Throws<ArgumentException>(() => new Triangle(1, -1, 1).GetArea());
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 1, 1).GetArea());

            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 4).GetArea());
            Assert.Throws<ArgumentException>(() => new Triangle(1, 4, 2).GetArea());
            Assert.Throws<ArgumentException>(() => new Triangle(4, 1, 2).GetArea());
        }

        [Fact]
        public void TriangleGetAreaTest()
        {              
            Assert.Equal(6, new Triangle(5, 4, 3).GetArea());
            Assert.Equal(10.825317547305483, new Triangle(5, 5, 5).GetArea());
            Assert.Equal(3.872983346207417, new Triangle(4, 4, 2).GetArea());
        }

        [Fact]
        public void TriangleIsRightAngledTest()
        {
            Assert.True(new Triangle(5,4,3).IsRightAngled());
            Assert.False(new Triangle(5, 5, 3).IsRightAngled());
        }

    }
}