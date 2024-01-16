namespace Mathematics.Test
{
    public class BasicMathTest
    {
        [Fact]
        public void AddNumbersTest()
        {
            BasicMath math = new BasicMath();

            double result = math.AddNumbers(1, 2);

            Assert.True(result == 3, $"actual: {result}");
        }

        [Fact]
        public void SubNumbersTest()
        {
            BasicMath math = new BasicMath();

            double result = math.SubNumbers(2, 1);

            Assert.True(result == 1, $"actual: {result}");
        }

        [Fact]
        public void MulNumbersTest()
        {
            BasicMath math = new BasicMath();

            double result = math.MulNumbers(1, 2);

            Assert.True(result == 2, $"actual: {result}");
        }

        [Fact]
        public void DivNumbersTest()
        {
            BasicMath math = new BasicMath();

            double result = math.DivNumbers(2, 1);

            Assert.True(result == 2, $"actual: {result}");
        }

        [Fact]
        public void ListCountTest()
        {
            BasicMath math = new BasicMath();

            List<double> list = new List<double>();

            list.Add(2);
            list.Add(4);
            list.Add(6);

            int result = math.ListCount(list);

            Assert.True(result == 3, $"{result} should have been 3");
        }
    }
}
