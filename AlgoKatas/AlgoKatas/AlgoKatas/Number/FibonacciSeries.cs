using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoKatas.Number
{
    /// <summary>
    /// Fibonnaci Series: F(n) = F(n-1) + F(n-2)
    /// F(n) is the term number.
    /// F(n-1) is the previous term (n-1).
    /// F(n-2) is the term before that (n-2).
    /// Example: 0,1,1,2,4,6...
    /// </summary>
    public class FibonacciSeries
    {
        public FibonacciSeries(bool recursiveWay = false)
        {
            RecursiveWay = recursiveWay;
        }

        public bool RecursiveWay { get; private  set; }

        public int GetNthNumber(int i)
        {
            if (RecursiveWay)
                return GetNthNumberRecursive(i);
            else
                return GetNthNumberNonRecursive(i);
        }

        private int GetNthNumberRecursive(int i)
        {
            if (i <= 1)
                return 0;
            if (i <= 2)
                return 1;
            return GetNthNumberRecursive(i - 1) + GetNthNumberRecursive(i - 2);
        }

        private int GetNthNumberNonRecursive(int n)
        {
            if (n <= 1)
                return 0;
            if (n <= 2)
                return 1;
            int ret = 0;
            int firstNumber = 0;
            int secondNumber = 1;
            for (int j = 3; j <= n; j++)
            {
                ret = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = ret;
            }

            return ret;
        }

    }
}
