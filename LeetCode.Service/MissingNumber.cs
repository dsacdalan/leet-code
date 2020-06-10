using System;
using System.Collections.Generic;

namespace LeetCode.Service
{
    public partial class Solution
    {
        public int MissingNumber(int[] nums) {
            var hashSet = new HashSet<int>();
            foreach(var num in nums) {
                hashSet.Add(num);
            }

            var max = nums.Length + 1;
            for(int i = 0; i < max; i++) {
                if (!hashSet.Contains(i)) return i;
            }
            
            return -1;
        }
    }
}