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
    public class WordCounterTest
    {
        WordCounter _counter;

        [SetUp]
        public void Init()
        {
            _counter = new WordCounter();
        }

        [TestCase("    Hello",1)]
        [TestCase("    Hello    ", 1)]
        [TestCase("    Hello    World     ", 2)]
        public void Should_return_correct_number_of_words_in_string(string input, int count)
        {
            
            //Arrange
            //Act
            var tmp = _counter.CountWord(input);
            //Assert
            tmp.Should().Be(count);
        }
    }
}
