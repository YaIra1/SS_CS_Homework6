namespace OverloadOperators
{
    public class Program
    {
        public static void Main(string[] consoleArguments)
        {
            var fraction1 = new Fraction(5, 7);
            var fraction2 = new Fraction(2, 3);

            var fraction3 = fraction1 * fraction2;

        }
    }
}