using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoKatas.Number;
using FluentAssertions;
using NUnit.Framework;

namespace AlgoKatas.Tests.Number
{
    [TestFixture]
    public class FactorialCalculatorTest
    {
        FactorialCalculator _calculator;

        [SetUp]
        public void Init()
        {
            _calculator = new FactorialCalculator();
        }

        [Test]
        public void Factorial_of_three_should_be_six()
        {
            //Arrange
            int n = 3;
            int expected = 6;
            //Act
            var tmp = _calculator.CalculateFactorial(n,false);
            var tmp2 = _calculator.CalculateFactorial(n,true);
            //Assert
            tmp.Should().Be(expected);
            tmp2.Should().Be(expected);

        }
        [Test]
        public void Factorial_of_five_should_be_120()
        {
            //Arrange
            int n = 5;
            int expected = 120;
            //Act
            var tmp = _calculator.CalculateFactorial(n, false);
            var tmp2 = _calculator.CalculateFactorial(n, true);
            //Assert
            tmp.Should().Be(expected);
            tmp2.Should().Be(expected);

        }
    }
}
