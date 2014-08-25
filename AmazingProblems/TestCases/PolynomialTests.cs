using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Polynomials;
using Problems.Polynomials.FormattingStrategies;

namespace TestCases
{
    [TestClass]
    public class PolynomialTests
    {
        [TestMethod]
        public void CanSolvePolynomial()
        {
            Polynomial polyOne = BuildPolyOne();
            Assert.AreEqual(6, polyOne.Solve(1));
            Assert.AreEqual(70, polyOne.Solve(5));
            Assert.AreEqual(4038, polyOne.Solve(37));

            Polynomial polyTwo = BuildPolyTwo();
            Assert.AreEqual(-320, polyTwo.Solve(1));
            Assert.AreEqual(2448, polyTwo.Solve(5));
            Assert.AreEqual(370647, polyTwo.Solve(-22));
        }

        [TestMethod]
        public void CanFormatAsDefaultPoly()
        {
            var defaultFormatter = new DefaultPolyFormatter();
            var polyOne = BuildPolyOne();
            var polyTwo = BuildPolyTwo();

            Assert.AreEqual("3x<sup>2</sup> -2x +5", polyOne.ToString(defaultFormatter));
            Assert.AreEqual("2x<sup>4</sup> +10x<sup>3</sup> +17x<sup>2</sup> -32x -317", polyTwo.ToString(defaultFormatter));
        }


        // Setup methods
        private Polynomial BuildPolyOne()
        {
            // 3x^2 -2x +5
            return new Polynomial()
                .AddTerm(new Term()
                {
                    Coefficient = 3,
                    Exponent = 2
                })

                .AddTerm(new Term()
                {
                    Coefficient = -2,
                    Exponent = 1
                })

                .AddTerm(new Term()
                {
                    Coefficient = 5,
                    Exponent = 0
                }
            );
        }

        private Polynomial BuildPolyTwo()
        {
            // 2x^4 +10x^3 +17x^2 -32x -317
            return new Polynomial()
                .AddTerm(new Term()
                {
                    Coefficient = 2,
                    Exponent = 4
                })

                .AddTerm(new Term()
                {
                    Coefficient = 10,
                    Exponent = 3
                })

                .AddTerm(new Term()
                {
                    Coefficient = 17,
                    Exponent = 2
                })

                .AddTerm(new Term()
                {
                    Coefficient = -32,
                    Exponent = 1
                })

                .AddTerm(new Term()
                {
                    Coefficient = -317,
                    Exponent = 0
                }
            );
        }
    }
}
