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
    public class AmstrongNumberTest
    {
        AmstrongNumber _amstrong;
        [SetUp]
        public void Init()
        {
            _amstrong = new AmstrongNumber();
        }

        [Test]
        public void The_number_371_should_be_amstrong_number()
        {
            //Arrange
            int n = 371;
            //Act
            bool tmp = _amstrong.IsAmstrongNumber(n);
            //Assert
            tmp.Should().BeTrue();
        }
    }
}
