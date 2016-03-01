using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoKatas.Number
{
    public class FactorialCalculator
    {
        public int CalculateFactorial(int n, bool useRecursion = false)
        {
            return useRecursion?  CalculateRecursion(n):CalculateNonRecursion(n);
        }

        private int CalculateNonRecursion(int n)
        {
            int ret = 1;
            for (int i = 1; i <= n; i++)
            {
                ret *= i;
            }

            return ret;
        }

        private int CalculateRecursion(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n*CalculateRecursion(n - 1);
            }
        }
    }
}
