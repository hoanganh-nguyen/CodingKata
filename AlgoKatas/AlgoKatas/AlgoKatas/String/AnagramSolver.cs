using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoKatas.String
{
    public class AnagramChecker
    {
        public bool IsAnagram(string s1, string s2)
        {
            //Step1: Convert to char array
            var char1 = s1.ToArray();
            var char2 = s2.ToArray();

            //Step2: Sort char arrays
            Array.Sort(char1);
            Array.Sort(char2);
            
            //Step3: Re-create strings from char array
            var newS1 = new System.String(char1);
            var newS2 = new System.String(char2);

            return newS1.Equals(newS2);
        }
    }


    /// <summary>
    /// Print all anagram
    /// </summary>
    public class AnagramSolver
    {

        public Dictionary<string, List<string>> FindAnagrams(List<string> input)
        {
            Dictionary<string, List<string>> ret = new Dictionary<string, List<string>>();
            foreach (string s in input)
            {
                var tmp = s.ToArray();
                Array.Sort(tmp);
                var key = new string(tmp);

                if (!ret.Keys.Contains(key))
                {
                    ret[key] = new List<string>();
                }
                else
                {
                    if (!ret[key].Contains(s))
                    {
                        ret[key].Add(s);
                    }
                }

            }
            return ret;
        }



    }
}
