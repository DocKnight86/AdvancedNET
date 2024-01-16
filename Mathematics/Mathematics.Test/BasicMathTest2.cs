namespace Mathematics.Test
{
    public class BasicMathTest2
    {
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
        public void ListSumTest()
        {
            BasicMath math = new BasicMath();

            List<double> list = new List<double>();

            list.Add(2);
            list.Add(4);
            list.Add(6);

            double result = math.ListSum(list);

            Assert.True(result == 12, $"{result} should have been 3");
        }
    }
}
