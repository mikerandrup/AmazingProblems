using System;
using System.Collections.Generic;
using Problems.Polynomials.FormattingStrategies.Components;

namespace Problems.Polynomials.FormattingStrategies
{
    public class DefaultPolyFormatter : PolynomialFormattingStrategy
    {
        public DefaultPolyFormatter()
        {
            CoefficientFormatter = new DefaultCoefficientFormatter();
            VariableFormatter = new DefaultVariableFormatter();
            ExponentFormatter = new DefaultExponentFormatter();
            
            PostProcessFormatters = 
                new List<IStringProcessor>() {
                    new RemoveInitialPlusCharacter(),
                    new TrimWhitespace()
                };
        }

        public override string Format(Term term)
        {
            return String.Format(
                "{0}{1}{2} ",
                CoefficientFormatter.Format(term),
                VariableFormatter.Format(term),
                ExponentFormatter.Format(term)
            );
        }
    }
}
