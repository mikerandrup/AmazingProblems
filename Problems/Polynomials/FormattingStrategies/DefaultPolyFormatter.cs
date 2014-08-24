using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Polynomials.FormattingStrategies
{
    public class DefaultPolyFormatter : BaseFormattingStrategy
    {
        private const string template = "{0}{1}{2}{3} ";
        private const string termString = "x";

        public override string ToFormattedString(Term term)
        {
            return String.Format(
                template,
                term.Coefficient > 0 ? "+" : "-",
                Math.Abs(term.Coefficient) > 1 ? Math.Abs(term.Coefficient).ToString() : String.Empty,
                term.Exponent > 0 ? termString : String.Empty,
                term.Exponent > 1 ? "^"+term.Exponent.ToString() : String.Empty
            );
        }
    }
}
