using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Service
{
    public partial class Solution
    {
        public int RomanToInt(string s) {
            var queue = new Queue<char>(s.ToCharArray().Reverse());
            var total = 0;
            var current = 0;

            while(queue.Count > 0)
            {
                var next = RomanCharToInt(queue.Dequeue());
                if (next < current)
                    total -= next;
                else
                    total += next;
                current = next;
            }

            return total;
        }

        private int RomanCharToInt(char c) {
            if (c == 'I') return 1;
            if (c == 'V') return 5;
            if (c == 'X') return 10;
            if (c == 'L') return 50;
            if (c == 'C') return 100;
            if (c == 'D') return 500;
            if (c == 'M') return 1000;

            return -1;
        }
    }
}