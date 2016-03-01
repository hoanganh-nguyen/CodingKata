using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoKatas.String;
using FluentAssertions;
using NUnit.Framework;

namespace AlgoKatas.Tests.String
{
    [TestFixture]
    public class StringReverserTest
    {
        StringReverser _reverser;

        [SetUp]
        public void Init()
        {
            _reverser = new StringReverser();

        }


        [TestCase("ABC","CBA")]
        public void Should_reverse_string(string input, string expected)
        {
            //Arrange
            //Act
            string ret = _reverser.Reverse(input);
            //Assert
            ret.Should().BeEquivalentTo(expected);

        }
    }
}
