using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
        public int[] solution(int[] progresses, int[] speeds)
        {
            int[] answer = new int[] { };
            List<int> ans = new List<int>();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < progresses.Length; i++)
            {
                int n = (100 - progresses[i]) / speeds[i];

                if ((100 - progresses[i]) % speeds[i] > 0) n += 1;

                progresses[i] = n;
            }

            // stack 할당
            for (int i = progresses.Length - 1; i >= 0; i--)
            {
                stack.Push(progresses[i]);
            }

            while(stack.Count > 0)
            {
                int day = stack.Pop();
                int j = 1;

                if (stack.Count <= 0)
                {
                    ans.Add(j);
                    break;

                }

                while(day >= stack.Peek() )
                {
                    stack.Pop();
                    j++;

                    if (stack.Count <= 0)
                    {
                        break;

                    }
                }

                ans.Add(j);
            }

            answer = ans.ToArray();
            return answer;
        }
}