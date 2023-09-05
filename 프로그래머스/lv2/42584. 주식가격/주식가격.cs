using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] prices) {
        int[] answer = new int[prices.Length];

        Stack<int> stack = new Stack<int>();


        for (int i = 0; i < prices.Length; i++)
        {
            while (stack.Count > 0 && prices[stack.Peek()] > prices[i])
            {

                int n = stack.Pop();
                answer[n] = i - n;

            }

            stack.Push(i);
        }

        while (stack.Count > 0)
        {
            int n = stack.Pop();
            answer[n] = prices.Length - 1 - n;
        }

        return answer;
    }
}