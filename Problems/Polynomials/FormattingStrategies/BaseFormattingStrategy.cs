using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Polynomials.FormattingStrategies
{
    public class BaseFormattingStrategy
    {
        public virtual string ToFormattedString(Term term)
        {
            return string.Empty;
        }
    }
}
