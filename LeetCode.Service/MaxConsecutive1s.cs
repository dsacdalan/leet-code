namespace LeetCode.Service
{
    public partial class Solution
    {
        public int LongestOnes(int[] A, int K) {
            var maxLeft = 0;
            var maxRight = 0;
            var left = 0;
            var right = 0;
            var counterIndex = 0;
            var counter = 0;
            
            for (int i = 0; i < A.Length; i++) {
                // If break
                if (A[i] == 0) {
                    counter++;
                    counterIndex = i;
                }
                // If we at K + 1 zeros
                if (counter > K) {
                    // if the current index is longer than our max,
                    // set this window ot max
                    if (right-left > maxRight - maxLeft) {
                        maxLeft = left;
                        maxRight = right;
                    }
                    // No matter what, reset our window
                    counter = 1;
                    left = counterIndex;
                    right = i;
                }
                // Extend window
                else {
                    right++;
                }
            }
            
            var currentTotal = right-left + 1;
            var maxTotal = maxRight - maxLeft + 1;

            return (maxTotal > currentTotal) ? maxTotal : currentTotal;
        }
    }
}