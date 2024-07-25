using MyLibrary;

namespace Test
{
    public class UnitTest
    {
        [Fact]
        public void Test()
        {
            double radius = 5;
            double expectedArea = Math.PI * radius * radius;

            double actualArea = Geometry.CircleArea(radius);

            Assert.Equal(expectedArea, actualArea, 5);
        }

        [Fact]
        public void CalculateCircleArea_ZeroOrNegativeRadius_ThrowsArgumentOutOfRangeException()
        {
            double radius = -1;

            Assert.Throws<ArgumentOutOfRangeException>(() => Geometry.CircleArea(radius));
        }

        [Fact]
        public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double s = (a + b + c) / 2;
            double expectedArea = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            double actualArea = Geometry.TriangleArea(a, b, c);

            Assert.Equal(expectedArea, actualArea, 5);
        }

        [Fact]
        public void CalculateTriangleArea_ZeroOrNegativeSide_ThrowsArgumentOutOfRangeException()
        {
            double a = -1;
            double b = 4;
            double c = 5;

            Assert.Throws<ArgumentOutOfRangeException>(() => Geometry.TriangleArea(a, b, c));
        }

        [Fact]
        public void CalculateTriangleArea_InvalidSides_ThrowsArgumentException()
        {
            double a = 1;
            double b = 2;
            double c = 10;

            Assert.Throws<ArgumentException>(() => Geometry.TriangleArea(a, b, c));
        }
    }
}
