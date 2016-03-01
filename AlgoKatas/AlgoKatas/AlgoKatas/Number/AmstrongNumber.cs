using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoKatas.Number
{
    /// <summary>
    /// An Armstrong number of three digits is an integer such that the sum of the cubes of its digits is equal to the number itself.
    /// Given number abc
    /// if a*100 + b*10 + c = a^3 + b^3 + c^3
    /// </summary>
    public class AmstrongNumber
    {
        public bool IsAmstrongNumber(int number)
        {
            int remainder = 0;
            int sum = 0;

            for (int i = number; i > 0; i = i / 10)
            {
                remainder = i % 10;
                sum = sum + remainder * remainder * remainder;

            }
            return sum == number;
        }
    }
}
