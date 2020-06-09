using System;

namespace LeetCode.Service
{
    public partial class Solution
    {
        public int TitleToNumber(string s) {
            var number = 0;
            for(int i = 0; i < s.Length; i++)
            {
                number = number * 26 + ((s[i] - 'A') + 1);
            }
            return number;
        }
    }
}