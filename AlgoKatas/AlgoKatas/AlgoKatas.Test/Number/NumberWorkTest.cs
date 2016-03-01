using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace AlgoKatas.Tests.Number
{
    [TestFixture]
    public class NumberWorkTest
    {

        [Test]
        public void Check_Division_Operation()
        {
            var tmp = 8%5;
            tmp.Should().Be(3);
            var tmp2 = 8/5;
            tmp2.Should().Be(1);
        }
    }
}
