using System;
using System.Collections.Generic;
using Problems.Polynomials.FormattingStrategies.Components;

namespace Problems.Polynomials.FormattingStrategies
{
    public class CompSciFormatter : PolynomialFormattingStrategy
    {
        public CompSciFormatter()
        {
            CoefficientFormatter = new CompSciCoefficientFormatter();
            VariableFormatter = new DefaultVariableFormatter();
            ExponentFormatter = new CompSciExponentFormatter();
            
            PostProcessFormatters = 
                new List<IStringProcessor>() {
                    new RemoveInitialPlusCharacter(),
                    new TrimWhitespace()
                };
        }

        public override string FormatTerm(Term term)
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