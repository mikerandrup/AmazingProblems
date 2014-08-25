using System;

namespace Problems.Polynomials.FormattingStrategies.Components
{
    public static class VariableRepresentations
    {
        public const string FirstVariable = "x";
    }

    public class DefaultCoefficientFormatter : IFormatter
    {
        public string Format(Term t)
        {
            return String.Format(
                "{0}{1}",
                t.Coefficient > 0 ? "+" : String.Empty,
                Math.Abs(t.Coefficient) > 1 ? t.Coefficient.ToString() : String.Empty
            );
        }
    }

    public class DefaultExponentFormatter : IFormatter
    {
        public string Format(Term t)
        {
            return
                t.Exponent > 1
                ? Superscript.Format(t.Exponent)
                : String.Empty;
        }
    }

    public class DefaultVariableFormatter : IFormatter
    {
        public string Format(Term t)
        {
            return
                t.Exponent > 0
                ? VariableRepresentations.FirstVariable
                : String.Empty;
        }
    }

    public class RemoveInitialPlusCharacter : IStringProcessor
    {
        public string Process(string s)
        {
            return s.StartsWith("+") ? s.Substring(1) : s;
        }
    }

    public class TrimWhitespace : IStringProcessor
    {
        public string Process(string s)
        {
            return s.Trim();
        }
    }
}
