using System;

namespace Problems.Polynomials.FormattingStrategies.Components
{
    public class CompSciCoefficientFormatter : IFormatter
    {
        public string Format(Term t)
        {
            return String.Format(
                "{0}({1}{2}",
                t.Coefficient > 0 ? "+" : "-",
                Math.Abs(t.Coefficient) > 1 ? Math.Abs(t.Coefficient).ToString() : String.Empty,
                t.Exponent > 0 ? "*" : String.Empty
            );
        }
    }

    public class CompSciExponentFormatter : IFormatter
    {
        public string Format(Term t)
        {
            return
                (t.Exponent > 1
                    ? "^" + t.Exponent 
                    : String.Empty)
                + ")";
        }
    }
}