using System.Collections.Generic;
using Problems.Polynomials.FormattingStrategies.Components;

namespace Problems.Polynomials.FormattingStrategies
{
    public abstract class PolynomialFormattingStrategy
    {
        protected IFormatter CoefficientFormatter;
        protected IFormatter VariableFormatter;
        protected IFormatter ExponentFormatter;
        public IEnumerable<IStringProcessor> PostProcessFormatters;

        public abstract string Format(Term term);
    }
}
