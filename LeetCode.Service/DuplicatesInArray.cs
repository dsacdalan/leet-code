using System;
using System.Collections.Generic;

namespace LeetCode.Service
{
    public partial class Solution
    {
        public IList<int> FindDuplicates(int[] nums) {
            var answers = new List<int>();
            for(int i = 0; i < nums.Length; i++)
            {
                var index = Math.Abs(nums[i]) - 1;
                // Negative
                if (nums[index] < 0) {
                    answers.Add(Math.Abs(nums[i]));
                }
                else {
                    nums[index] = -nums[index];
                }
            }
            return answers;
        }
    }
}