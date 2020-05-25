using System.Collections.Generic;

namespace LeetCode.Service
{
    public class RecentCounter {
    
        private int _max;
        private Queue<int> _queue;
      
        public RecentCounter() {
            _max = 3000;
            _queue = new Queue<int>();
        }
        
        public int Ping(int t)
        {
            _queue.Enqueue(t);
            
            while(_queue.Count > 0)
            {
                if (t - _max > _queue.Peek())
                    _queue.Dequeue();
                else
                    break;
            }
            
            return _queue.Count;
        }
    }
}