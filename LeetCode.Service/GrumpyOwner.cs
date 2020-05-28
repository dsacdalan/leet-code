using System.Linq;

namespace LeetCode.Service
{
    public partial class Solution
    {
        public int MaxSatisfied(int[] customers, int[] grumpy, int X) {
            // check for invalid
            if (X > customers.Length) {
                return customers.Sum();
            }

            // get first window
            int max = 0;
            int startIndex = 0;
            for (int i = 0; i < X; i++) {
                if (grumpy[i] == 1)
                    max += customers[i];
            }
            var current = max;

            for (int i = X; i < customers.Length; i++) {
                // If current is grumpy
                if (grumpy[i] == 1) {
                    current += customers[i];
                }
                var currentStart = i - X;
                if (grumpy[currentStart] == 1) {
                    current -= customers[currentStart];
                }
                if (current > max) {
                    max = current;
                    startIndex = currentStart + 1;
                }
            }

            var answer = 0;
            for (int i = 0; i < customers.Length; i++) {
                if (grumpy[i] == 0) {
                    answer += customers[i];
                }
                else if (i >= startIndex && i <= startIndex + X - 1) 
                {
                    answer += customers[i];
                }
            }

            return answer;
        }
    }
}