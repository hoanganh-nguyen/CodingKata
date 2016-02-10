using System.Collections.Generic;
using System.Linq;
using AlgoKatas.String;
using FluentAssertions;
using NUnit.Framework;

namespace AlgoKatas.Tests.String
{
    [TestFixture()]
    public class AnagramSolverTests
    {
        private AnagramSolver _solver;

        [SetUp]
        public void Init()
        {
            _solver = new AnagramSolver();
        }


        [Test()]
        public void FindAnagramsTest()
        {
            //Arrange
            List<string> list = new List<string> {"lion", "zebra", "noli", "onli", "braze", "breaz", "cat", "dog"};
            //Act
            var ret = _solver.FindAnagrams(list);
            //Assert
            int count = ret.Keys.Count(s => ret[s].Count >= 2);

            
            
        }
    }
}
