using System;

namespace Problems.Polynomials.FormattingStrategies.Components
{
    public static class Superscript
    {
        public static string Format(object obj)
        {
            return String.Format("<sup>{0}</sup>", obj.ToString());
        }
    }
}