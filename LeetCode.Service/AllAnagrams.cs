using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Service
{
    public partial class Solution
    {
        public IList<int> FindAnagrams(string s, string p) {
            var anagrams = new List<int>();
            if (p.Length > s.Length) return anagrams;

            // Fill hash
            var hash = new int[26];
            foreach(var letter in p) {
                hash[CharIndex(letter)]++; 
            }

            var left = 0;
            var right = 0;
            var count = 0;
            
            while(right < s.Length) {
                
                // Move right
                var letter = s[right++];

                // Check if it is in p and mark as visited
                if (hash[CharIndex(letter)] > 0)
                {
                    // Valid letter
                    count++;
                }
                hash[CharIndex(letter)]--;

                // If all valid letters found, add the index
                if (count == p.Length) anagrams.Add(left);
                
                // Move left
                if (right - left == p.Length) {
                    var leftLetter = s[left++];
                    // Check if it is in p and mark as visited
                    if (hash[CharIndex(leftLetter)] >= 0) {
                        // loose valid letter
                        count--;
                    }
                    hash[CharIndex(leftLetter)]++;
                }
            }

            return anagrams;
        }
        private int CharIndex(char index) {
            return index - 'a';
        }
    }
}