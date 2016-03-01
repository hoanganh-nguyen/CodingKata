using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace AlgoKatas.String
{
    [TestFixture]
    public class PalindromeTest
    {
        Palindrome _palinedrome;

        [SetUp]
        public void Init()
        {
            _palinedrome = new Palindrome();
        }

        [TestCase("kayak")]
        [TestCase("Kayak")]
        [TestCase("civic")]
        [TestCase("deleveled")]
        [TestCase("Hannah")]
        [TestCase("level")]
        [TestCase("racecar")]
        [TestCase("radar")]
        [TestCase("refer")]
        [TestCase("rotator")]
        [TestCase("rotor")]
        [TestCase("solos")]
        [TestCase("stats")]
        [TestCase("tenet")]
        public void Should_be_palindrome(string input)
        {
            //Act
            var tmp =_palinedrome.IsPalindrome(input);
            var tmp2 = _palinedrome.IsPalindrome2(input);
            //Assert
            tmp.Should().BeTrue();
            tmp2.Should().BeTrue();
        }

        [TestCase("examiron")]
        [TestCase("Csharpstar")]
        [TestCase("easywcf")]
        public void Should_not_be_palindrome(string input)
        {
            //Act
            var tmp = _palinedrome.IsPalindrome(input);
            var tmp2 = _palinedrome.IsPalindrome2(input);
            //Assert
            tmp.Should().BeFalse();
            tmp2.Should().BeFalse();
        }


    }
}
