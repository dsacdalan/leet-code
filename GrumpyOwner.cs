using System.Linq;

namespace leetcode
{
    public class GrumpyOwner
    {
        public int MaxSatisfied(int[] customers, int[] grumpy, int X) {
            // check for invalid
            if (X > customers.Length) {
                return customers.Sum();
            }

            // get first window
            int max = 0;
            int maxIndex = 0;
            for (int i = 0; i < X; i++) {
                if (grumpy[i] == 1)
                    max += customers[i];
            }

            for (int i = X; i < customers.Length; i++) {
                var current = max;
                if (grumpy[i] == 1)
                    current += customers[i];
                if (grumpy[i - X] == 1)
                    current -= customers [i - X];
                if (current > max) {
                    max = current;
                    maxIndex = i - X + 1;
                }               
            }

            var answer = 0;
            for (int i = 0; i < customers.Length; i++) {
                if (i < maxIndex || i > maxIndex + X) {
                    if (grumpy[i] == 0) {
                        answer += customers[i];
                    }
                }
                else {
                    answer += customers[i];
                }
            }

            return answer;
        }
    }
}