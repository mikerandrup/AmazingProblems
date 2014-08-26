using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.ChemSpell
{
    public class WorkSummary
    {
        public WorkSummary()
        {
            SymbolsUsed = new Stack<string>();
        }
        
        private const string messageTemplate =
            "{0} was the longest word ({1} chars). [ {2} ]";

        public override string ToString()
        {
            return String.Format(
                messageTemplate,
                LongestWordFound,
                LongestWordFound.Length,
                HowItWasSpelled
            );
        }

        public string LongestWordFound { get; set; }
        public string HowItWasSpelled
        {
            get
            {
                return String.Join(".", SymbolsUsed.ToArray().Reverse());
            }
        }

        public void RecordAttemptedSymbol(string sym)
        {
            SymbolsUsed.Push(sym);
        }
        public void RemoveLastSymbol()
        {
            SymbolsUsed.Pop();
        }
        private Stack<String> SymbolsUsed;

    }
}
