using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoKatas.Number
{
    /// <summary>
    /// A prime number (or a prime) is a natural number greater than 1 that has no positive divisors other than 1 and itself.
    /// </summary>
    public class PrimeChecker
    {
        public bool IsPrime(int n)
        {
            if(n<=1)
                return false;

            int factor = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n%i == 0)
                    factor ++;
            }

            return factor == 2;
        }

    }
}
