using AlgoKatas.String;
using FluentAssertions;
using NUnit.Framework;

namespace AlgoKatas.Tests.String
{
    [TestFixture()]
    public class AnagramCheckerTests
    {
        private AnagramChecker _checker;

        [SetUp]
        public void Init()
        {
            _checker = new AnagramChecker();
        }

        [Test()]
        public void These_strings_should_be_anagrams()
        {
           //Arrange
            string s1 = "act";
            string s2 = "tac";
            //Act
            var ret =_checker.IsAnagram(s1, s2);

            //Assert
            ret.Should().Be(true);
        }

        [Test()]
        public void These_strings_should_be_not_anagrams()
        {
            //Arrange
            string s1 = "act";
            string s2 = "tactic";
            //Act
            var ret = _checker.IsAnagram(s1, s2);

            //Assert
            ret.Should().Be(false);
        }
    }
}
