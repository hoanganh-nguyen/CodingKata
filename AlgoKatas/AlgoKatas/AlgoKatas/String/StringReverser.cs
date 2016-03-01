using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoKatas.String
{
    public class StringReverser
    {
        public string Reverse(string input)
        {
            Stack<char> list = new Stack<char>();
            foreach (var c in input)
            {
                list.Push(c);
            }
            return list.Aggregate("", (current, ch) => current + ch);
        }
    }
}
