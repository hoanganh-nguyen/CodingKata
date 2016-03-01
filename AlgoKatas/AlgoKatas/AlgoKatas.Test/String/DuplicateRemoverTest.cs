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
    public class DuplicateRemoverTest
    {
        DuplicateRemover _remover;

        [SetUp]
        public void Init()
        {
            _remover = new DuplicateRemover();
        }

        [TestCase("Google","Gogle")]
        [TestCase("CNN", "CN")]
        [TestCase("BBC", "BC")]
        [TestCase("ABC", "ABC")]
        public void Should_remove_duplicate_characters(string input, string expected)
        {
            
            //Arrange
            var output = _remover.RemoveDuplicateCharacters(input);
            //Assert
            output.Should().BeEquivalentTo(expected);
        }

    }
}
