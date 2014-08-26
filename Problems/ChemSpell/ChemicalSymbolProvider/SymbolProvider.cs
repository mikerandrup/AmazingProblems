using System;
using System.Collections.Generic;

namespace Problems.ChemSpell.ChemicalSymbolProvider
{
    public static class SymbolProvider
    {
        private static IEnumerable<String> _symbols;
        public static IEnumerable<String> ChemicalSymbols
        {
            get
            {
                if (_symbols == null)
                {
                    _symbols = new List<String>()
                    {
                        "h", "he", "li", "be", "b", "c",
                        "n", "o", "f", "ne", "na", "mg",
                        "al", "si", "p", "s", "cl", "ar",
                        "k", "ca", "sc", "ti", "v", "cr",
                        "mn", "fe", "co", "ni", "cu", "zn",
                        "ga", "ge", "as", "se", "br", "kr",
                        "rb", "sr", "y", "zr", "nb", "mo",
                        "tc", "ru", "rh", "pd", "ag", "cd",
                        "in", "sn", "sb", "te", "i", "xe",
                        "cs", "ba", "la", "ce", "pr", "nd",
                        "pm", "sm", "eu", "gd", "tb", "dy",
                        "ho", "er", "tm", "yb", "lu", "hf",
                        "ta", "w", "re", "os", "ir", "pt",
                        "au", "hg", "tl", "pb", "bi", "po",
                        "at", "rn", "fr", "ra", "ac", "th",
                        "pa", "u", "np", "pu", "am", "cm",
                        "bk", "cf", "es", "fm", "md", "no",
                        "lr", "rf", "db", "sg", "bh", "hs",
                        "mt", "ds", "rg", "cn", "uut", "fl",
                        "uup", "lv", "uus", "uuo"
                    };
                }
                return _symbols;
            }
        }
    }
}