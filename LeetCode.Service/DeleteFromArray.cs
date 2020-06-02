namespace LeetCode.Service
{
    public partial class Solution
    {
        public int RemoveDuplicates(int[] nums) {
            if (nums.Length == 0) return 0;

            var iter = 0;
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[iter])
                {
                    nums[++iter] = nums[i];
                }
            }
            return iter + 1;
        }
    }
}