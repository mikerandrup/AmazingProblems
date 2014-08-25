using System;
using Problems.Polynomials.FormattingStrategies;

namespace Problems.Polynomials
{
    public class Term
    {
        public int Coefficient = 1;
        public int Exponent = 1;

        public int SolveForTerm(int x)
        {
            return Coefficient * (int)Math.Pow(x, Exponent);
        }

        public string ToString(PolynomialFormattingStrategy formatter) {
            return formatter.FormatTerm(this);
        }
    }
}
