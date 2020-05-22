namespace leetcode
{
    public class BinarySearch_Template_1
    {
        public int MySqrt(int x) {
            if (x < 2)
                return x;

            ulong newX = (ulong)x;

            ulong left = 1;
            ulong right = newX / 2;
            ulong answer = 0;
            while (left <= right) {
                ulong middle = left + (right - left) / 2;

                ulong square = middle * middle;
                if (square == (ulong)x) return (int)middle;
                if (square < newX) {
                    left = middle + 1;
                    answer = middle;
                }
                else {
                    right = middle - 1;
                }
            }

            return (int)answer;
        }
    }
}