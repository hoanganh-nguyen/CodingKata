using AlgoKatas.Number;
using FluentAssertions;
using NUnit.Framework;

namespace AlgoKatas.Tests.Number
{
    [TestFixture()]
    public class PrimeCheckerTests
    {
        private PrimeChecker _checker;

        [SetUp]
        public void Init()
        {
            _checker = new PrimeChecker();
        }

        [Test()]
        public void One_should_be_not_prime()
        {
            //Arrange
            int n = 1;
            //Act
            var tmp = _checker.IsPrime(n);
            //Assert
            tmp.Should().Be(false);

        }
        [Test()]
        public void Two_should_be_prime()
        {
            //Arrange
            int n = 2;
            //Act
            var tmp = _checker.IsPrime(n);
            //Assert
            tmp.Should().Be(true);

        }

        [Test()]
        public void Four_should_be_not_prime()
        {
            //Arrange
            int n = 4;
            //Act
            var tmp = _checker.IsPrime(n);
            //Assert
            tmp.Should().Be(false);

        }

        [Test]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        [TestCase(11)]
        public void This_number_should_be_prime(int n)
        {
            _checker.IsPrime(n).Should().Be(true);
        }

        [Test]
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(8)]
        public void This_number_should_be__not_prime(int n)
        {
            _checker.IsPrime(n).Should().Be(false);
        }

    }
}
