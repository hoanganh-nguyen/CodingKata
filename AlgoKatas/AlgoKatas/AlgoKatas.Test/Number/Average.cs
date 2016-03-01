using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AlgoKatas.Tests.Number
{
    public class Average
    {
        double CalculateAverage(int a, int b)
        {
            
        return a + b / 2;
        }
    }
    
    [TestFixture]
    public class AverageTest
    {

        [Test]
        public void test()
        {
            var input = new int[] {1, 1, 2, 3, 5, 8};
            int count = input.Length;

        }

    }
}
