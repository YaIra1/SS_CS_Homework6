
namespace OverloadOperators
{
    public class Fraction
    {
        private long _numerator;
        private long _denominator;

        public long Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }

        public long Denominator
        {
            get { return _denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Can't assign 0 to denominator");
                }
                _denominator = value;
            }
        }

        public Fraction(long numerator, long denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.Numerator == b.Numerator && a.Denominator == b.Denominator;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            return a.Numerator * b.Denominator < a.Denominator * b.Numerator;
        }

        public static bool operator <=(Fraction a, Fraction b)
        {
            return a.Numerator * b.Denominator <= a.Denominator * b.Numerator;
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            return a.Numerator * b.Denominator > a.Denominator * b.Numerator;
        }

        public static bool operator >=(Fraction a, Fraction b)
        {
            return a.Numerator * b.Denominator >= a.Denominator * b.Numerator;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            var newNum = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            var newDen = a.Denominator * b.Denominator;

            return new Fraction(newNum, newDen);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            var newNum = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            var newDen = a.Denominator * b.Denominator;
            
            return new Fraction(newNum, newDen);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            var newNum = a.Numerator * b.Numerator;
            var newDen = a.Denominator * b.Denominator;

            return new Fraction(newNum, newDen);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            var newNum = a.Numerator * b.Denominator;
            var newDen = a.Denominator * b.Numerator;

            return new Fraction(newNum, newDen);
        }
    }
}
