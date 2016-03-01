using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoKatas.String
{
    public class DuplicateRemover
    {
        public string RemoveDuplicateCharacters(string input)
        {
            string listOfCharaters = "";
            string result = "";
            foreach (var c in input)
            {
                if (listOfCharaters.IndexOf(c) == -1)
                {
                    listOfCharaters += c;
                    result += c;
                }
            }

            return result;
        }

    }
}
