using Mathematics;

namespace MathematicsConsole
{
    class Program
    {
        private static double _num1;
        private static double _num2;
        private static string _operand;
        private static List<double> _numList;

        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();

            AreArgumentsValid(args);

            BasicMath math = new BasicMath();
            
            switch (_operand)
            {
                case "add":
                {
                    Console.WriteLine($"{_num1} + {_num2} = {math.AddNumbers(_num1, _num2)}");
                    break;
                }
                case "sub":
                {
                    Console.WriteLine($"{_num1} - {_num2} = {math.SubNumbers(_num1, _num2)}");
                    break;
                }
                case "mul":
                {
                    Console.WriteLine($"{_num1} * {_num2} = {math.MulNumbers(_num1, _num2)}");
                    break;
                }
                case "div":
                {
                    Console.WriteLine($"{_num1} / {_num2} = {math.DivNumbers(_num1, _num2)}");
                    break;
                }
                case "area":
                {
                    Console.WriteLine($"{_num1} * {_num2} = {AdvMath.CalculateArea(_num1, _num2)}");
                    break;
                }
                case "average":
                {
                    string numberList = string.Join(", ", _numList);
                    double averageResult = AdvMath.CalculateAverage(_numList);
                    Console.WriteLine($"Average of {numberList} = {averageResult}");
                    break;
                }
                case "squared":
                {
                    Console.WriteLine($"{_num1} squared = {AdvMath.CalculateSquared(_num1)}");
                    break;
                }
                case "theorem":
                {
                    Console.WriteLine($"{_num1} + {_num2} = {AdvMath.CalculatePythagoreanTheorem(_num1, _num2)}");
                    break;
                }
                default:
                {
                    Console.WriteLine($"{_operand} is not a valid operator. Please enter Add, Sub, Mul, Div, Area, Squared, Theorem");
                    break;
                }
            }

            Console.ReadLine();
        }

        public static void AreArgumentsValid(string[] args)
        {
            _operand = args[1].ToLower();

            if (_operand == "average")
            {
                _numList = new List<double>();

                for (int i = 2; i < args.Length; i++)
                {
                    if (double.TryParse(args[i], out double number))
                    {
                        _numList.Add(number);
                    }
                    else
                    {
                        Console.WriteLine($"Unable to parse {args[i]}.");
                        Environment.Exit(99);
                    }
                }
                if (_numList.Count == 0)
                {
                    Console.WriteLine("No numbers provided for average calculation.");
                    Environment.Exit(99);
                }
            }

            _num1 = NumParser(args[2]);

            // Handles all other cases except for squared.
            if (_operand != "squared")
            {
                _num2 = NumParser(args[3]);
            }

            Console.WriteLine("All Arguments are valid!");
        }

        public static double NumParser(string arg)
        {
            if (double.TryParse(arg, out double number))
            {
                return number; 
            }

            Console.WriteLine($"Unable to parse {arg}.");
            Environment.Exit(99);

            return 0;
        }
    }
}
