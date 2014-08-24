using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public string ToFormattedString(BaseFormattingStrategy formStrat) {
            return formStrat.ToFormattedString(this);
        }
    }
}
