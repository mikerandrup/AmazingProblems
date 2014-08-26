using System;
using Problems.ChemSpell.ChemicalSymbolProvider;
using Problems.ChemSpell.EnglishWordProvider;

namespace Problems.ChemSpell
{
    public class ChemSpell
    {
        public ChemSpell()
        {
            WS = new WorkSummary();
        }

        public WorkSummary TryToSpellLongWordsWithChemicalSymbols () {
            foreach (string word in WordProvider.WordsSortedByLengthDescending) {
                if (AttemptToSpellWord(word))
                    return WS;
            }
            return WS;
        }

        private bool AttemptToSpellWord(string word)
        {
            if (IsSpellable(word))
            {
                WS.LongestWordFound = word;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsSpellable(string remainderOfWord)
        {
            if (remainderOfWord == String.Empty)
                return true;

            foreach (string chem in SymbolProvider.ChemicalSymbols)
            {
                if (remainderOfWord.StartsWith(chem))
                {
                    WS.RecordAttemptedSymbol(chem);
                    bool remainderWasSpellable = IsSpellable(
                        remainderOfWord.Substring(chem.Length)
                    );

                    if (remainderWasSpellable)
                        return true;
                    else
                        WS.RemoveLastSymbol();
                }
            }
            return false;
        }

        private WorkSummary WS;
    }
}
