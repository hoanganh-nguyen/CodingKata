using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoKatas.String
{
    public class WordCounter
    {

        public int CountWord(string input)
        {
            input = input.Trim();
            //Replace many space by only one
            string cleanedString = System.Text.RegularExpressions.Regex.Replace(input, @"\s+", " ");
            return cleanedString.Split(' ').Length;
        }
    }
}
