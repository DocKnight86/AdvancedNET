namespace Mathematics
{
    public class AdvMath
    {
        public static double CalculateArea(double height, double width)
        {
            return height * width;
        }

        public static double CalculateAverage(List<double> values)
        {
            if (values == null || values.Count == 0)
            {
                throw new ArgumentException("Values list cannot be null or empty.");
            }

            return values.Average();
        }

        public static double CalculateSquared(double value)
        {
            return value * value;
        }

        public static double CalculatePythagoreanTheorem(double a, double b)
        {
            return Math.Sqrt(CalculateSquared(a) + CalculateSquared(b));
        }
    }
}
