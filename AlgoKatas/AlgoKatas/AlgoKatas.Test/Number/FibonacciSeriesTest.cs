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
    public class FibonacciSeriesTest
    {
        private FibonacciSeries _fibonacci;

        [SetUp]
        public void Init()
        {
            _fibonacci = new FibonacciSeries();
        }

        [Test]
        public void The_first_number_of_fibonnaci_series_should_be_zero()
        {
            //Arrange
            int n = 1;
            //Act
            var tmp = _fibonacci.GetNthNumber(n);
            //Assert
            tmp.Should().Be(0);
        }

        [Test]
        public void The_second_number_of_fibonnaci_series_should_be_one()
        {
            //Arrange
            int n =2;
            //Act
            var tmp = _fibonacci.GetNthNumber(n);
            //Assert
            tmp.Should().Be(1);
        }

        [Test]
        public void The_third_number_of_fibonnaci_series_should_be_one()
        {
            //Arrange
            int n = 3;
            //Act
            var tmp = _fibonacci.GetNthNumber(n);
            //Assert
            tmp.Should().Be(1);
        }

        [Test]
        public void The_fourth_number_of_fibonnaci_series_should_be_two()
        {
            //Arrange
            int n = 4;
            //Act
            var tmp = _fibonacci.GetNthNumber(n);
            //Assert
            tmp.Should().Be(2);
        }

        [Test]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(10)]
        public void The_nth_number_of_fibonnaci_series_should_be_sum_of_two_precedent_numbers_in_series(int n)
        {
            //Arrange
            var n_1 = _fibonacci.GetNthNumber(n - 1);
            var n_2 = _fibonacci.GetNthNumber(n - 2);
            //Act
            var tmp = _fibonacci.GetNthNumber(n);
            //Assert
            tmp.Should().Be(n_1 + n_2);
        }
    }
}
