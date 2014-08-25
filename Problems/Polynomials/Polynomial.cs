using System.Collections.Generic;
using System.Text;
using Problems.Polynomials.FormattingStrategies;
using Problems.Polynomials.FormattingStrategies.Components;

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

        public string ToString(PolynomialFormattingStrategy formatter)
        {
            var sb = new StringBuilder();

            foreach (Term t in this)
            {
                sb.Append(t.ToString(formatter));
            }
            string s = sb.ToString();

            foreach (IStringProcessor sp in formatter.PostProcessFormatters)
            {
                s = sp.Process(s);
            }

            return s;
        }
    }
}
