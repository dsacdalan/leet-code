namespace LeetCode.Service
{
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target) {
            int left = 0;
            int right = nums.Length - 1;
            
            while(right >= left)
            {
                var middle = (left + right) / 2;
                
                if (nums[middle] == target)
                    return middle;

                // Move down
                if (nums[middle] > target)
                    right = middle - 1;
                // Move up
                else
                    left = middle + 1;
            }

            return left;
        }
    }
}