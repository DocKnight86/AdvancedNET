namespace Mathematics.Test
{
    public class AdvMathTest
    {
        [Fact]
        public void TestCalculateArea()
        {
            double height = 5;
            double width = 10;
            double expected = 50;

            double result = AdvMath.CalculateArea(height, width);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCalculateAverage()
        {
            List<double> values = new List<double> { 1.0, 2.0, 3.0, 4.0, 5.0 };
            double expected = 3.0;

            double result = AdvMath.CalculateAverage(values);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCalculateAverageWithEmptyList()
        {
            List<double> values = new List<double>();

            ArgumentException exception = Assert.Throws<ArgumentException>(() => AdvMath.CalculateAverage(values));

            Assert.Equal("Values list cannot be null or empty.", exception.Message);
        }

        [Fact]
        public void TestCalculateSquared()
        {
            double value = 5;
            double expected = 25;

            double result = AdvMath.CalculateSquared(value);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCalculatePythagoreanTheorem()
        {
            double a = 3;
            double b = 4;
            double expected = 5;

            double result = AdvMath.CalculatePythagoreanTheorem(a, b);

            Assert.Equal(expected, result);
        }
    }
}
