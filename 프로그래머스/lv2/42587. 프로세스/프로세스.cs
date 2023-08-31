using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
        public int solution(int[] priorities, int location)
        {
            int answer = 0;

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < priorities.Length ; i++)
            {
                queue.Enqueue(priorities[i]);
            }

            Queue<bool> boolQueue = new Queue<bool>();
            bool[] bools = new bool[priorities.Length];
            bools[location] = true;

            for (int i = 0; i < priorities.Length; i++)
            {
                boolQueue.Enqueue(bools[i]);
            }

            int cnt = 0;

            while (queue.Count > 0)
            {
                int m = queue.Max();
                int n = queue.Dequeue();
                bool b = boolQueue.Dequeue();

                if(m > n) 
                {
                    queue.Enqueue(n);
                    boolQueue.Enqueue(b);
                    continue;
                }
                if(b)
                {
                    answer = ++cnt;
                    return answer;
                }

                cnt++;
            }


            return answer;
        }
}