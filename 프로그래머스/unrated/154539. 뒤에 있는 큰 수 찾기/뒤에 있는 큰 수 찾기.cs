using System;
using System.Linq;
using System.IO.Pipes;
using System.Collections.Generic;

public class Solution
    {
        public int[] solution(int[] numbers)
        {
            int[] answer = new int[] { };
            answer = new int[numbers.Length];
            
                        Stack<int> stack = new Stack<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                while (stack.Count > 0 && numbers[stack.Peek()] < numbers[i])
                {
                    answer[stack.Pop()] = numbers[i];  // 현재 원소보다 작은 원소들의 결과를 갱신
                }
                stack.Push(i);
                answer[i] = -1;  // 초기화
            }
            
            return answer;
        }
    }