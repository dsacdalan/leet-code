using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Service
{

    public class TaskScheduler {

        public int LeastInterval(char[] tasks, int n)
        {
            var cooldown = new int[26];
            var intTasks = new int[tasks.Length];
            // Convert char to int
            for(int i = 0; i < tasks.Length; i++)
            {
                intTasks[i] = (int)tasks[i] - 65;
            }

            var queue = new Queue<int>(intTasks);
            var counter = 0;

            while(queue.Count > 0)
            {
                var current = queue.Dequeue();

                // check if on cooldown
                if (cooldown[current] != 0)
                {
                    // Move task back to queue
                    queue.Enqueue(current);
                    FindNext(queue, cooldown, queue.Count, n);
                    LowerCooldown(cooldown);
                }

                // if not on cooldown
                else
                {
                    LowerCooldown(cooldown);
                    cooldown[current] = n;
                }

                counter++;
            }

            return counter;
        }

        private void FindNext(Queue<int> queue, int[] cooldown, int length, int n)
        {
            for(int i = 0; i < length; i++)
            {
                var current = queue.Dequeue();
                // found one
                if (cooldown[current] == 0)
                {
                    cooldown[current] = n;
                    break;
                }
                if (cooldown[current] != 0)
                {
                    queue.Enqueue(current);
                }
            }
        }

        private void LowerCooldown(int[] cooldown)
        {
            for(int i = 0; i < cooldown.Length; i++)
            {
                if (cooldown[i] > 0)
                    cooldown[i]--;
            }
        }
    }
}