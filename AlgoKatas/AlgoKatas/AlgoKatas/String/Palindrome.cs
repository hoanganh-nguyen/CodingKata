using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace AlgoKatas.String
{
    public class Palindrome
    {
        //First solution: Reverse string then compare with original
        public bool IsPalindrome(string input)
        {
            string newStr = input.ToLower();
            Stack<char> reversedList = new Stack<char>();
            foreach (var c in newStr)
            {
                reversedList.Push(c);
            }
            string reversedStr = reversedList.Aggregate("", (current, c) => current += c);

            return reversedStr.Equals(newStr);

        }

        //Compare character by character from begin/end to pivot
        public bool IsPalindrome2(string input)
        {
            int max = input.Length - 1;
            int min = 0;
            while (max > min)
            {
                char a = input[min];
                char b = input[max];
                if (!char.ToLower(a).Equals(char.ToLower(b)))
                {
                    return false;
                }
                max--;
                min++;
            }
            return true;

        }
    }
}
