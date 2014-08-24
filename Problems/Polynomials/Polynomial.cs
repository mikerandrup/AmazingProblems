using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems.Polynomials.FormattingStrategies;

namespace Problems.Polynomials
{
    public class Polynomial : List<Term>
    {
        public Polynomial() : base() {}

        public Polynomial AddTerm(Term term)
        {
            this.Add(term);
            return this;
        }

        public int Solve(int x)
        {
            int solvedTotal = 0;
            foreach (Term t in this)
            {
                solvedTotal += t.SolveForTerm(x);
            }
            return solvedTotal;
        }

        public string ToFormattedString(BaseFormattingStrategy formatter)
        {
            var sb = new StringBuilder();

            foreach (Term t in this)
            {
                sb.Append(t.ToFormattedString(formatter));
            }

            return sb.ToString().Trim();
        }
    }
}
