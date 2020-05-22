using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var current = new GrumpyOwner();

            var customers = new int[] {1,0,1,2,1,1,7,5};
            var grumpy = new int[] {0,1,0,1,0,1,0,1};

            current.MaxSatisfied(customers, grumpy, 3);

;        }
    }
}
