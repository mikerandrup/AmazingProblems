using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.MabLids;
using Problems.MabLids.EssayComponents;
using Problems.MabLids.EssayComponents.DynamicComponents;
using Problems.Polynomials;
using Problems.Polynomials.FormattingStrategies;

namespace TestCases
{
    [TestClass]
    public class MabLidsTests
    {
        [TestMethod]
        public void EssayCanRender()
        {
            Essay sportsRookieEssay = BuildEssayOne();

            string sportsEssayAsString = sportsRookieEssay.ToString();

            Assert.IsFalse(String.IsNullOrWhiteSpace(sportsEssayAsString));

        }

        public Essay BuildEssayOne()
        {

            var nameNoun = new Noun().SetValue("Bob Dole");
            var groupNoun = new Noun().SetValue("The FBI");
            var groupNounParent = new Noun().SetValue("Rock Band 'The Cure'");
            var verbOne = new Verb().SetValue("executed");
            var verbTwo = new Verb().SetValue("flapping");
            var amount = new Number().SetValue("eleventy-billion");

            var bodilyFunctionNoun = new Noun().SetValue("acne");
            var timePeriodNoun = new Noun().SetValue("nanosecond");
            var adjectiveOne = new Adjective().SetValue("uncomfortable");
            var actionNoun = new Noun().SetValue("bloodletting");
            var propertyNoun = new Noun().SetValue("malaria");

            return new Essay()
                .Append(new StaticComponent("After being cut by "))
                .Append(groupNoun)
                .Append(new StaticComponent(", what is next for "))
                .Append(nameNoun)
                .Append(new StaticComponent("?\n\nNow that "))
                .Append(nameNoun)
                .Append(new StaticComponent(" has been "))
                .Append(verbOne)
                .Append(new StaticComponent(" by the "))
                .Append(groupNoun)
                .Append(new StaticComponent(", "))
                .Append(verbTwo)
                .Append(new StaticComponent(" to make their season-opening "))
                .Append(amount)
                .Append(new StaticComponent("-man roster, the question becomes: What's next?\n\n It appears that, following a "))
                .Append(adjectiveOne)
                .Append(new StaticComponent(" preseason, he will have a home in the "))
                .Append(groupNounParent)
                .Append(new StaticComponent(", although it's not immediately clear where that will be or what roster "))
                .Append(propertyNoun)
                .Append(new StaticComponent(" he will have.\n\nFor "))
                .Append(nameNoun)
                .Append(new StaticComponent(", that "))
                .Append(bodilyFunctionNoun)
                .Append(new StaticComponent(" now continues for at least another "))
                .Append(timePeriodNoun)
                .Append(new StaticComponent(" as he awaits the next "))
                .Append(actionNoun)
                .Append(new StaticComponent(" in his "))
                .Append(groupNounParent)
                .Append(new StaticComponent(" career."));
        }
    }
}