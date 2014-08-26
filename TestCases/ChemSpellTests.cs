using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.ChemSpell;

namespace TestCases
{
    [TestClass]
    public class ChemSpellTests
    {
        [TestMethod]
        public void WeCanSpellAWord()
        {
            WorkSummary ws = new ChemSpell().TryToSpellLongWordsWithChemicalSymbols();

            Assert.IsNotNull(ws.LongestWordFound);
        }
    }
}
