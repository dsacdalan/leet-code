using System.Collections.Generic;

namespace LeetCode.Service
{
    public partial class Solution
    {
        public int LengthOfLongestSubstring(string s) {
        var set = new HashSet<char>();
        var answer = 0;
        var left = 0;
        var right = 0;
        
        while (left < s.Length && right < s.Length) {
            if (!set.Contains(s[right])) {
                set.Add(s[right++]);
                var move = right - left;
                answer = (answer > move) ? answer : move;
            }
            else {
                set.Remove(s[left++]);
            }
        }
        
        
        return answer;
    }
    }
}