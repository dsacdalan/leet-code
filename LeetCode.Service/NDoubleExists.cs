using System.Collections.Generic;

namespace LeetCode.Service
{
    public partial class Solution
    {
        public bool CheckIfExist(int[] arr) {
            var hashSet = new HashSet<int>();
            
            for(int i = 0; i < arr.Length; i++)
            {   
                if (hashSet.Contains(arr[i] * 2)) return true;
                if (arr[i] % 2 == 0)
                    if (hashSet.Contains(arr[i] / 2)) return true;
                hashSet.Add(arr[i]);
            }

            return false;
        }
    }
}